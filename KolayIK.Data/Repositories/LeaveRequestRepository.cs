using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using KolayIK.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class LeaveRequestRepository : Repository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(KolayIKDBContext context) : base(context)
        {
        }
        public async Task<IEnumerable<LeaveRequest>> GetByEmployeeIdAsync(int employeeId)
        {
            return await KolayIKDBContext.LeaveRequests
                .Where(x => x.UserID == employeeId)
                .Include(x => x.State)
                .Include(x => x.Approver)
                .Include(x => x.LeaveType)
                .ToListAsync();
        }
        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}