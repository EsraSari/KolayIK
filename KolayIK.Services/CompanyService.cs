using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            return await unitOfWork.Companies.GetByIDAsync(id);
        }

        public async Task<IEnumerable<CompanyDTO>> GetAllCompaniesAsync()
        {
            var companies = await unitOfWork.Companies
                .GetAllAsync();

            var companyDTO = new List<CompanyDTO>();
            foreach (var c in companies)
            {
                var dto = new CompanyDTO
                {
                    Id = c.ID,
                    CompanyName = c.CompanyName,
                    Phone = c.Phone,
                    Address = c.Address,
                    ManagerName = c.Manager != null ? $"{c.Manager.FirstName} {c.Manager.LastName}" : "Belirtilmedi",
                    Approver = c.Approver != null ? $"{c.Approver.FirstName} {c.Approver.LastName}" : "Belirtilmedi",
                    State = c.ApprovalStatus?.StateName ?? "Belirtilmedi",
                    StateID = c.ApprovalStatusID,
                    ApprovalDate = c.ApprovalDate,
                    AddedDate = c.AddedDate,
                    ModifiedDate = c.ModifiedDate
                };
                companyDTO.Add(dto);
            }
            return companyDTO;
        }

        public async Task<IEnumerable<CompanyDTO>> GetApprovedCompaniesAsync()
        {
            var companies = await unitOfWork.Companies
                .GetAllApprovedCompaniesAsync();

            var companyDTO = new List<CompanyDTO>();
            foreach (var c in companies)
            {
                var dto = new CompanyDTO
                {
                    Id = c.ID,
                    CompanyName = c.CompanyName,
                    Phone = c.Phone,
                    Address = c.Address,
                    ManagerName = c.Manager != null ? $"{c.Manager.FirstName} {c.Manager.LastName}" : "Belirtilmedi",
                    Approver = c.Approver != null ? $"{c.Approver.FirstName} {c.Approver.LastName}" : "Belirtilmedi",
                    State = c.ApprovalStatus?.StateName ?? "Belirtilmedi",
                    StateID = c.ApprovalStatusID,
                    ApprovalDate = c.ApprovalDate,
                    AddedDate = c.AddedDate,
                    ModifiedDate = c.ModifiedDate
                };
                companyDTO.Add(dto);
            }

            return companyDTO;
        }

        public async Task<IEnumerable<CompanyDTO>> GetPendingCompaniesAsync()
        {
            var companies = await unitOfWork.Companies
                .GetPendingApprovalCompaniesAsync();

            var companyDTO = new List<CompanyDTO>();
            foreach (var c in companies)
            {
                var dto = new CompanyDTO
                {
                    Id = c.ID,
                    CompanyName = c.CompanyName,
                    Phone = c.Phone,
                    Address = c.Address,
                    ManagerName = c.Manager != null ? $"{c.Manager.FirstName} {c.Manager.LastName}" : "Belirtilmedi",
                    Approver = c.Approver != null ? $"{c.Approver.FirstName} {c.Approver.LastName}" : "Belirtilmedi",
                    State = c.ApprovalStatus?.StateName ?? "Belirtilmedi",
                    StateID = c.ApprovalStatusID,
                    ApprovalDate = c.ApprovalDate,
                    AddedDate = c.AddedDate,
                    ModifiedDate = c.ModifiedDate
                };
                companyDTO.Add(dto);
            }

            return companyDTO;
        }

        public async Task<IEnumerable<CompanyDTO>> GetRejectedCompaniesAsync()
        {
            var companies = await unitOfWork.Companies
                .GetRejectedApprovalCompaniesAsync();

            var companyDTO = new List<CompanyDTO>();
            foreach (var c in companies)
            {
                var dto = new CompanyDTO
                {
                    Id = c.ID,
                    CompanyName = c.CompanyName,
                    Phone = c.Phone,
                    Address = c.Address,
                    ManagerName = c.Manager != null ? $"{c.Manager.FirstName} {c.Manager.LastName}" : "Belirtilmedi",
                    Approver = c.Approver != null ? $"{c.Approver.FirstName} {c.Approver.LastName}" : "Belirtilmedi",
                    State = c.ApprovalStatus?.StateName ?? "Belirtilmedi",
                    StateID = c.ApprovalStatusID,
                    ApprovalDate = c.ApprovalDate,
                    AddedDate = c.AddedDate,
                    ModifiedDate = c.ModifiedDate
                };
                companyDTO.Add(dto);
            }

            return companyDTO;
        }

        public async Task<Company> CreateCompanyAsync(SaveCompanyDTO companyDTO)
        {
            var newCompany = new Company
            {
                CompanyName = companyDTO.CompanyName,
                Phone = companyDTO.Phone,
                Address = companyDTO.Address,
                ManagerID = companyDTO.ManagerID
            };
            await unitOfWork.Companies.AddAsync(newCompany);
            await unitOfWork.CommitAsync();
            return newCompany;
        }

        public async Task UpdateCompanyAsync(Company companyToUpdate, UpdateCompanyDTO updatedCompanyDto)
        {
            companyToUpdate.CompanyName = updatedCompanyDto.CompanyName;
            companyToUpdate.Phone = updatedCompanyDto.Phone;
            companyToUpdate.ApprovalStatusID = updatedCompanyDto.StateID;
            if (updatedCompanyDto.StateID != 1)
            {
                companyToUpdate.ApprovalDate = DateTime.Now;
            }
            await unitOfWork.CommitAsync();
        }
        public async Task<bool> DeleteCompanyAsync(int companyID)
        {
            var company = await unitOfWork.Companies.GetByIDAsync(companyID);
            if (company == null)
            {
                return false;
            }
            unitOfWork.Companies.Remove(company);
            await unitOfWork.CommitAsync();
            return true;
        }
        public async Task<IEnumerable<CompanyDTO>> GetCompaniesByManagerIDAsync(int employeeId)
        {

            var companies = await unitOfWork.Companies
                .GetCompaniesByManagerIDAsync(employeeId);

            var companyDTO = new List<CompanyDTO>();
            foreach (var c in companies)
            {
                var dto = new CompanyDTO
                {
                    Id = c.ID,
                    CompanyName = c.CompanyName,
                    Phone = c.Phone,
                    Address = c.Address,
                    ManagerName = c.Manager != null ? $"{c.Manager.FirstName} {c.Manager.LastName}" : "Belirtilmedi",
                    Approver = c.Approver != null ? $"{c.Approver.FirstName} {c.Approver.LastName}" : "Belirtilmedi",
                    State = c.ApprovalStatus?.StateName ?? "Belirtilmedi",
                    StateID = c.ApprovalStatusID,
                    ApprovalDate = c.ApprovalDate,
                    AddedDate = c.AddedDate,
                    ModifiedDate = c.ModifiedDate
                };
                companyDTO.Add(dto);
            }
            return companyDTO;
            
        }
    
    }
}
