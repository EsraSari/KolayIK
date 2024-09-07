using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class ExpenseRequestService : IExpenseRequestService
    {
        private readonly IUnitOfWork unitOfWork;
        public ExpenseRequestService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<ExpenseRequest> CreateExpenseReq(SaveExpenseReqDTO expenseReq)
        {
            var user = await unitOfWork.Users.GetUserWithRoleByUserID(expenseReq.UserID);

            if (user == null)
            {
                return null;
            }

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
            var newExpenseRequest = new ExpenseRequest
            {
                UserID = expenseReq.UserID,
                Amount = expenseReq.Amount,
                Description = expenseReq.Description,
                StateID = stateID,
                ApproverID = managerID,
                ApprovalDate = null
            };

            await unitOfWork.ExpenseRequests.AddAsync(newExpenseRequest);
            await unitOfWork.CommitAsync();

            return newExpenseRequest;
        }
        public async Task<bool> DeleteExpenseRequest(int id)
        {
            var expReq = await unitOfWork.ExpenseRequests.GetByIDAsync(id);
            if (expReq == null)
            {
                return false;
            }

            unitOfWork.ExpenseRequests.Remove(expReq);
            await unitOfWork.CommitAsync();
            return true;
        }
        public async Task<IEnumerable<ExpenseRequestDTO>> GetAllExpenseRequests()
        {
            var expenseReq = await unitOfWork.ExpenseRequests
                 .GetAllAsync();

            var expenseReqDtos = new List<ExpenseRequestDTO>();
            foreach (var expense in expenseReq)
            {
                var dto = new ExpenseRequestDTO
                {
                    Id = expense.ID,
                    Amount = expense.Amount,
                    Description = expense.Description,
                    StateName = expense.State.StateName ?? "Belirtilmedi",
                    ApproverName = expense.Approver != null ? $"{expense.Approver.FirstName} {expense.Approver.LastName}" : "Belirtilmedi",
                    ApprovalDate = expense.ApprovalDate,
                    AddedDate = expense.AddedDate,
                    ModifiedDate = expense.ModifiedDate
                };
                expenseReqDtos.Add(dto);
            }
            return expenseReqDtos;
        }
        public async Task<IEnumerable<ExpenseRequestDTO>> GetExpenseReqByEmpId(int employeeID)
        {
            var expenseReq = await unitOfWork.ExpenseRequests
                 .GetByEmployeeIdAsync(employeeID);

            var expenseReqDtos = new List<ExpenseRequestDTO>();
            foreach (var expense in expenseReq)
            {
                var dto = new ExpenseRequestDTO
                {
                    Id = expense.ID,
                    Amount = expense.Amount,
                    Description = expense.Description,
                    StateName = expense.State.StateName ?? "Belirtilmedi",
                    ApproverName = expense.Approver != null ? $"{expense.Approver.FirstName} {expense.Approver.LastName}" : "Belirtilmedi",
                    ApprovalDate = expense.ApprovalDate,
                    AddedDate = expense.AddedDate,
                    ModifiedDate = expense.ModifiedDate
                };
                expenseReqDtos.Add(dto);
            }
            return expenseReqDtos;
        }

        public async Task<ExpenseRequest> GetExpenseReqById(int id)
        {
            return await unitOfWork.ExpenseRequests.GetByIDAsync(id);
        }

        public async Task<bool> UpdateExpenseRequest(int id, SaveExpenseReqDTO newExpenseReq)
        {
            var expenseReq = await unitOfWork.ExpenseRequests.GetByIDAsync(id);
            if (expenseReq == null)
            {
                return false;
            }
            expenseReq.Amount = newExpenseReq.Amount;
            expenseReq.Description = newExpenseReq.Description;
            expenseReq.StateID = newExpenseReq.StateID;
            expenseReq.ApprovalDate = newExpenseReq.StateID != 1 ? DateTime.Now : null;
            expenseReq.ModifiedDate = DateTime.Now;

            await unitOfWork.CommitAsync();

            return true;
        }
        public async Task<IEnumerable<ExpenseRequestDTO>> GetExpenseRequestsByManagerIdAsync(int managerID)
        {
            var expenseRequests = new List<ExpenseRequestDTO>();

            var managerExpenseRequests = await GetExpenseReqByEmpId(managerID);
            foreach (var expenseReq in managerExpenseRequests)
            {
                var expenseReqDTO = new ExpenseRequestDTO
                {
                    Id = expenseReq.Id,
                    Amount= expenseReq.Amount,
                    StateName = expenseReq.StateName,
                    ApproverName = expenseReq.ApproverName,
                    ApprovalDate = expenseReq.ApprovalDate,
                    AddedDate = expenseReq.AddedDate,
                    ModifiedDate = expenseReq.ModifiedDate
                };

                expenseRequests.Add(expenseReqDTO);
            }

            var users = await unitOfWork.Users.GetAllUsersByManagerIDAsync(managerID);

            foreach (var user in users)
            {
                var userExpenseRequests = await GetExpenseReqByEmpId(user.Id);

                foreach (var expenseRequest in userExpenseRequests)
                {
                    var userExpenseRequestDTO = new ExpenseRequestDTO
                    {
                        Id = expenseRequest.Id,
                        Amount = expenseRequest.Amount,
                        StateName = expenseRequest.StateName,
                        ApproverName = expenseRequest.ApproverName,
                        ApprovalDate = expenseRequest.ApprovalDate,
                        AddedDate = expenseRequest.AddedDate,
                        ModifiedDate = expenseRequest.ModifiedDate
                    };

                    expenseRequests.Add(userExpenseRequestDTO);
                }
            }

            return expenseRequests;
        }
    }
}
