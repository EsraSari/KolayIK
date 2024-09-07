using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IExperienceService
    {
        Task<Experience> CreateExperience(SaveExperienceDTO experienceDTO);
        Task DeleteExperience(Experience experience);
        Task<IEnumerable<Experience>> GetAllExperiences();
        Task<Experience> GetExperienceById(int id);
        Task<IEnumerable<Experience>> GetExperiencesByResumeId(int resumeId);
        Task UpdateExperience(Experience experienceToBeUpdated, SaveExperienceDTO newExperienceDTO);
    }

}
