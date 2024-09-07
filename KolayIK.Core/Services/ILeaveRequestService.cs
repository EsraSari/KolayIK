using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface ILeaveRequestService
    {
        Task<IEnumerable<LeaveRequest>> GetAllLeaveRequests();
        Task<LeaveRequest> GetLeaveReqById(int id);
        Task<LeaveRequest> CreateLeaveReq(SaveLeaveReqDTO leaveReq);
        Task<bool> UpdateLeaveRequest(int leaveReqId, SaveLeaveReqDTO newLeaveReq);
        Task DeleteLeaveRequest(LeaveRequest leaveRequest);
        Task<IEnumerable<LeaveReqDTO>> GetLeaveReqByEmpId(int employeeID);
        Task<IEnumerable<LeaveReqDTO>> GetLeaveRequestsByManagerIdAsync(int managerID);
    }
}
