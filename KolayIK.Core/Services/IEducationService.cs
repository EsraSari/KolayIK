using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IEducationService
    {
        Task<Education> CreateEducation(SaveEducationDTO educationDTO);
        Task DeleteEducation(Education education);
        Task UpdateEducation(Education educationToBeUpdated, SaveEducationDTO newEducationDTO);
        Task<IEnumerable<Education>> GetAllEducations();
        Task<Education> GetEducationById(int id);
        Task<IEnumerable<Education>> GetEducationsByResumeId(int resumeId);
        
    }

}
