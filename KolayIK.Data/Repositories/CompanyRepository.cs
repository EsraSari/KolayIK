using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(KolayIKDBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Company>> GetAllApprovedCompaniesAsync()
        {
            return await KolayIKDBContext.Companies
            .Include(x => x.ApprovalStatus)
            .Include(x => x.Approver)
            .Include(x => x.Manager)
            .Where(c => c.ApprovalStatusID == 2)
            .ToListAsync();
        }

        public async Task<IEnumerable<Company>> GetPendingApprovalCompaniesAsync()
        {
            return await KolayIKDBContext.Companies
            .Include(x => x.ApprovalStatus)
            .Include(x => x.Approver)
            .Include(x => x.Manager)
            .Where(c => c.ApprovalStatusID == 1) 
            .ToListAsync();
        }

        public async Task<IEnumerable<Company>> GetRejectedApprovalCompaniesAsync()
        {
            return await KolayIKDBContext.Companies
            .Include(x => x.ApprovalStatus)
            .Include(x => x.Approver)
            .Include(x => x.Manager)
            .Where(c => c.ApprovalStatusID == 3)
            .ToListAsync();
        }
        public async Task<IEnumerable<Company>> GetCompaniesByManagerIDAsync(int managerID)
        {
            return await KolayIKDBContext.Companies
                .Where(c => c.ManagerID == managerID)
                .Include(x => x.ApprovalStatus)
                .Include(x => x.Approver)
                .Include(x => x.Manager)
                .ToListAsync();
        }
        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await KolayIKDBContext.Companies
                .Include(x => x.ApprovalStatus)
                .Include(x => x.Approver)
                .Include(x => x.Manager)
                .ToListAsync();
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
