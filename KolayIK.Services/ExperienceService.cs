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
    public class ExperienceService : IExperienceService
    {
        private readonly IUnitOfWork unitOfWork;

        public ExperienceService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<Experience> CreateExperience(SaveExperienceDTO experienceDTO)
        {
            var newExperience = new Experience
            {
                CompanyName = experienceDTO.CompanyName,
                StartDate = experienceDTO.StartDate,
                EndDate = experienceDTO.EndDate,
                PositionID = experienceDTO.PositionID,
                ResumeID = experienceDTO.ResumeID
            };

            await unitOfWork.Experiences.AddAsync(newExperience);
            await unitOfWork.CommitAsync();

            return newExperience;
        }

        public async Task DeleteExperience(Experience experience)
        {
            unitOfWork.Experiences.Remove(experience);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Experience>> GetAllExperiences()
        {
            return await unitOfWork.Experiences.GetAllAsync();
        }

        public async Task<Experience> GetExperienceById(int id)
        {
            return await unitOfWork.Experiences.GetByIDAsync(id);
        }

        public async Task<IEnumerable<Experience>> GetExperiencesByResumeId(int resumeId)
        {
            return await unitOfWork.Experiences.FindAsync(e => e.ResumeID == resumeId);
        }

        public async Task UpdateExperience(Experience experienceToBeUpdated, SaveExperienceDTO newExperienceDTO)
        {
            experienceToBeUpdated.CompanyName = newExperienceDTO.CompanyName;
            experienceToBeUpdated.StartDate = newExperienceDTO.StartDate;
            experienceToBeUpdated.EndDate = newExperienceDTO.EndDate;
            experienceToBeUpdated.PositionID = newExperienceDTO.PositionID;

            await unitOfWork.CommitAsync();
        }
    }
}

