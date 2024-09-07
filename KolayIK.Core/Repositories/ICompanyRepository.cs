using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<IEnumerable<Company>> GetAllApprovedCompaniesAsync();
        Task<IEnumerable<Company>> GetPendingApprovalCompaniesAsync();
        Task<IEnumerable<Company>> GetRejectedApprovalCompaniesAsync();
        Task<IEnumerable<Company>> GetAllAsync();
        Task<IEnumerable<Company>> GetCompaniesByManagerIDAsync(int managerID);
    }

}
