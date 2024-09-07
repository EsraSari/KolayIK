using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IExpenseRequestRepository : IRepository<ExpenseRequest>
    {
        Task<IEnumerable<ExpenseRequest>> GetByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<ExpenseRequest>> GetAllExpenseRequests();
    }
}
