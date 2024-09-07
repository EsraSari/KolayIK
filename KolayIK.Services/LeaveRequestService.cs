using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IUserService userService;
        public LeaveRequestService(IUnitOfWork _unitOfWork, IUserService _userService)
        {
            unitOfWork = _unitOfWork;
            userService = _userService;

        }
        public async Task<LeaveRequest> CreateLeaveReq(SaveLeaveReqDTO leaveReq)
        {
            var user = await unitOfWork.Users.GetUserWithRoleByUserID(leaveReq.UserID);

            if (user == null)
            {
                return null;
            }
            if (user.RemainingLeave == 0)
                return null;


            int managerID;
            int stateID = 1;
            if (user.RoleID != 1)
            {
                var company = await unitOfWork.Companies.SingleOrDefaultAsync(c => c.ID == user.CompanyID);

                if (company != null)
                {
                    managerID = company.ManagerID;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                managerID = user.Id;
                stateID = 2;
            }

            var newLeaveRequest = new LeaveRequest
            {
                UserID = leaveReq.UserID,
                StartDate = leaveReq.StartDate,
                EndDate = leaveReq.EndDate,
                Description = leaveReq.Description,
                LeaveTypeID = leaveReq.LeaveTypeID,
                StateID = stateID,
                TotalTime = (leaveReq.EndDate - leaveReq.StartDate).TotalDays,
                ApproverID = managerID,
                ApprovalDate = null
            };

            var requestedTime = user.RemainingLeave - newLeaveRequest.TotalTime;

            if (requestedTime < 0)
                return null;

            await unitOfWork.LeaveRequests.AddAsync(newLeaveRequest);
            await unitOfWork.CommitAsync();

            if (stateID == 2)
            {
                var userUpdate = await unitOfWork.Users.GetByIDAsync(leaveReq.UserID);
                var updatedUser = new SaveUserDTO
                {
                    RemainingLeave = user.RemainingLeave - newLeaveRequest.TotalTime,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Salary = user.Salary
            };

                await userService.UpdateUser(userUpdate, updatedUser);
            }

            return newLeaveRequest;
        }

        public async Task DeleteLeaveRequest(LeaveRequest leaveRequest)
        {
            unitOfWork.LeaveRequests.Remove(leaveRequest);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<LeaveRequest>> GetAllLeaveRequests()
        {
            return await unitOfWork.LeaveRequests.GetAllAsync();
        }

        public async Task<IEnumerable<LeaveReqDTO>> GetLeaveReqByEmpId(int employeeID)
        {
            var leaveReq = await unitOfWork.LeaveRequests
                .GetByEmployeeIdAsync(employeeID);

            var leaveReqDtos = new List<LeaveReqDTO>();
            foreach (var lr in leaveReq)
            {
                var dto = new LeaveReqDTO
                {
                    Id = lr.ID,
                    StartDate = lr.StartDate,
                    EndDate = lr.EndDate,
                    TotalTime = lr.TotalTime,
                    Description = lr.Description,
                    LeaveTypeName = lr.LeaveType.LeaveTypeName ?? "Belirtilmedi",
                    StateName = lr.State.StateName ?? "Belirtilmedi",
                    ApproverName = lr.Approver != null ? $"{lr.Approver.FirstName} {lr.Approver.LastName}" : "Belirtilmedi",
                    ApprovalDate = lr.ApprovalDate,
                    AddedDate = lr.AddedDate,
                    ModifiedDate = lr.ModifiedDate
                };

                leaveReqDtos.Add(dto);
            }

            return leaveReqDtos;
        }

        public async Task<LeaveRequest> GetLeaveReqById(int id)
        {
            return await unitOfWork.LeaveRequests.GetByIDAsync(id);
        }

        public async Task<bool> UpdateLeaveRequest(int leaveReqId, SaveLeaveReqDTO newLeaveReq)
        {
            var leaveReqToBeUpdated = await unitOfWork.LeaveRequests.GetByIDAsync(leaveReqId);
            if (leaveReqToBeUpdated == null)
            {
                return false;
            }

            leaveReqToBeUpdated.StartDate = newLeaveReq.StartDate;
            leaveReqToBeUpdated.EndDate = newLeaveReq.EndDate;
            leaveReqToBeUpdated.Description = newLeaveReq.Description;
            leaveReqToBeUpdated.LeaveTypeID = newLeaveReq.LeaveTypeID;
            leaveReqToBeUpdated.TotalTime = (newLeaveReq.EndDate - newLeaveReq.StartDate).TotalDays;
            leaveReqToBeUpdated.StateID = newLeaveReq.StateID;
            leaveReqToBeUpdated.ApprovalDate = newLeaveReq.StateID != 1 ? DateTime.Now : null;
            leaveReqToBeUpdated.ModifiedDate = DateTime.Now;
            leaveReqToBeUpdated.UserID = newLeaveReq.UserID;

            if (newLeaveReq.StateID == 2)
            {
                var userToUpdate = await unitOfWork.Users.GetByIDAsync(newLeaveReq.UserID);
                if (userToUpdate == null)
                {
                    return false;
                }

                var newRemainingLeave = userToUpdate.RemainingLeave - (newLeaveReq.EndDate - newLeaveReq.StartDate).TotalDays;

                if (newRemainingLeave < 0)
                {
                    return false;
                }
                userToUpdate.RemainingLeave = newRemainingLeave;
            }

            await unitOfWork.CommitAsync(); 

            return true;
        }



        public async Task<IEnumerable<LeaveReqDTO>> GetLeaveRequestsByManagerIdAsync(int managerID)
        {
            var leaveRequests = new List<LeaveReqDTO>();

            var managerLeaveRequests = await GetLeaveReqByEmpId(managerID);
            foreach (var leaveRequest in managerLeaveRequests)
            {
                var leaveRequestDTO = new LeaveReqDTO
                {
                    Id = leaveRequest.Id,
                    StartDate = leaveRequest.StartDate,
                    EndDate = leaveRequest.EndDate,
                    Description = leaveRequest.Description,
                    LeaveTypeName = leaveRequest.LeaveTypeName,
                    StateName = leaveRequest.StateName,
                    TotalTime = leaveRequest.TotalTime,
                    ApproverName = leaveRequest.ApproverName,
                    ApprovalDate = leaveRequest.ApprovalDate,
                    AddedDate = leaveRequest.AddedDate,
                    ModifiedDate = leaveRequest.ModifiedDate
                };

                leaveRequests.Add(leaveRequestDTO);
            }

            var users = await unitOfWork.Users.GetAllUsersByManagerIDAsync(managerID);

            foreach (var user in users)
            {
                var userLeaveRequests = await GetLeaveReqByEmpId(user.Id);

                foreach (var leaveRequest in userLeaveRequests)
                {
                    var leaveRequestDTO = new LeaveReqDTO
                    {
                        Id = leaveRequest.Id,
                        StartDate = leaveRequest.StartDate,
                        EndDate = leaveRequest.EndDate,
                        Description = leaveRequest.Description,
                        LeaveTypeName = leaveRequest.LeaveTypeName,
                        StateName = leaveRequest.StateName,
                        TotalTime = leaveRequest.TotalTime,
                        ApproverName = leaveRequest.ApproverName,
                        ApprovalDate = leaveRequest.ApprovalDate,
                        AddedDate = leaveRequest.AddedDate,
                        ModifiedDate = leaveRequest.ModifiedDate
                    };

                    leaveRequests.Add(leaveRequestDTO);
                }
            }

            return leaveRequests;
        }




    }
}
