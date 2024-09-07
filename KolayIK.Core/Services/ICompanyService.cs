using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyByIdAsync(int id);
        Task<IEnumerable<CompanyDTO>> GetAllCompaniesAsync();
        Task<IEnumerable<CompanyDTO>> GetApprovedCompaniesAsync();
        Task<IEnumerable<CompanyDTO>> GetPendingCompaniesAsync();
        Task<IEnumerable<CompanyDTO>> GetRejectedCompaniesAsync();
        Task<Company> CreateCompanyAsync(SaveCompanyDTO company);
        Task UpdateCompanyAsync(Company companyToUpdate, UpdateCompanyDTO updatedCompanyDto);
        Task<bool> DeleteCompanyAsync(int companyID);
        Task<IEnumerable<CompanyDTO>> GetCompaniesByManagerIDAsync(int managerID);
    }
}
