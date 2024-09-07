using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IExpenseRequestService
    {
        Task<IEnumerable<ExpenseRequestDTO>> GetAllExpenseRequests();
        Task<ExpenseRequest> GetExpenseReqById(int id);
        Task<ExpenseRequest> CreateExpenseReq(SaveExpenseReqDTO expenseReq);
        Task<bool> UpdateExpenseRequest(int id, SaveExpenseReqDTO newExpenseReq);
        Task<bool> DeleteExpenseRequest(int id);
        Task<IEnumerable<ExpenseRequestDTO>> GetExpenseReqByEmpId(int employeeID);
        Task<IEnumerable<ExpenseRequestDTO>> GetExpenseRequestsByManagerIdAsync(int managerID);

    }
}
