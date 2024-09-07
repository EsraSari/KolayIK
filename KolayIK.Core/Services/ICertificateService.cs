using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface ICertificateService
    {
        Task<Certificate> CreateCertificate(SaveCertificateDTO certificateDTO);
        Task DeleteCertificate(Certificate certificate);
        Task UpdateCertificate(Certificate certificateToBeUpdated, SaveCertificateDTO newCertificateDTO);
        Task<IEnumerable<Certificate>> GetAllCertificates();
        Task<Certificate> GetCertificateById(int id);
        Task<IEnumerable<Certificate>> GetCertificatesByResumeId(int resumeId);
        
    }

}
