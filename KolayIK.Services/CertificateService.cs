using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly IUnitOfWork unitOfWork;

        public CertificateService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<Certificate> CreateCertificate(SaveCertificateDTO certificateDTO)
        {
            var newCertificate = new Certificate
            {
                Name = certificateDTO.Name,
                IssuedBy = certificateDTO.IssuedBy,
                IssueDate = certificateDTO.IssueDate,
                ExpiryDate = certificateDTO.ExpiryDate,
                Description = certificateDTO.Description,
                ResumeID = certificateDTO.ResumeID
            };

            await unitOfWork.Certificates.AddAsync(newCertificate);
            await unitOfWork.CommitAsync();

            return newCertificate;
        }

        public async Task DeleteCertificate(Certificate certificate)
        {
            unitOfWork.Certificates.Remove(certificate);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Certificate>> GetAllCertificates()
        {
            return await unitOfWork.Certificates.GetAllAsync();
        }

        public async Task<Certificate> GetCertificateById(int id)
        {
            return await unitOfWork.Certificates.GetByIDAsync(id);
        }

        public async Task<IEnumerable<Certificate>> GetCertificatesByResumeId(int resumeId)
        {
            return await unitOfWork.Certificates.FindAsync(c => c.ResumeID == resumeId);
        }

        public async Task UpdateCertificate(Certificate certificateToBeUpdated, SaveCertificateDTO newCertificateDTO)
        {
            certificateToBeUpdated.Name = newCertificateDTO.Name;
            certificateToBeUpdated.IssuedBy = newCertificateDTO.IssuedBy;
            certificateToBeUpdated.IssueDate = newCertificateDTO.IssueDate;
            certificateToBeUpdated.ExpiryDate = newCertificateDTO.ExpiryDate;
            certificateToBeUpdated.Description = newCertificateDTO.Description;

            await unitOfWork.CommitAsync();
        }
    }

}
