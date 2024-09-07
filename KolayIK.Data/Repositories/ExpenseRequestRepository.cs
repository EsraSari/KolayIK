using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class ExpenseRequestRepository : Repository<ExpenseRequest>, IExpenseRequestRepository
    {
        public ExpenseRequestRepository(KolayIKDBContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ExpenseRequest>> GetByEmployeeIdAsync(int employeeId)
        {
            return await KolayIKDBContext.ExpenseRequests
                .Include(u => u.User)
                .Include(x => x.State)
                .Include(a => a.Approver)
                .Where(x => x.UserID == employeeId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ExpenseRequest>> GetAllExpenseRequests()
        {
            return await KolayIKDBContext.ExpenseRequests
                .Include(u => u.User)
                .Include(x => x.State)
                .Include(a => a.Approver)
                .ToListAsync();
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
