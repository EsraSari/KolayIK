using KolayIK.Core.Modal;
using KolayIK.Core;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolayIK.Core.DTO;

namespace KolayIK.Services
{
    public class EducationService : IEducationService
    {
        private readonly IUnitOfWork unitOfWork;

        public EducationService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<Education> CreateEducation(SaveEducationDTO educationDTO)
        {
            var newEducation = new Education
            {
                SchoolName = educationDTO.SchoolName,
                StartDate = educationDTO.StartDate,
                EndDate = educationDTO.EndDate,
                ResumeID = educationDTO.ResumeID
            };

            await unitOfWork.Educations.AddAsync(newEducation);
            await unitOfWork.CommitAsync();

            return newEducation;
        }

        public async Task DeleteEducation(Education education)
        {
            unitOfWork.Educations.Remove(education);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Education>> GetAllEducations()
        {
            return await unitOfWork.Educations.GetAllAsync();
        }

        public async Task<Education> GetEducationById(int id)
        {
            return await unitOfWork.Educations.GetByIDAsync(id);
        }

        public async Task<IEnumerable<Education>> GetEducationsByResumeId(int resumeId)
        {
            return await unitOfWork.Educations.FindAsync(e => e.ResumeID == resumeId);
        }

        public async Task UpdateEducation(Education educationToBeUpdated, SaveEducationDTO newEducationDTO)
        {
            educationToBeUpdated.SchoolName = newEducationDTO.SchoolName;
            educationToBeUpdated.StartDate = newEducationDTO.StartDate;
            educationToBeUpdated.EndDate = newEducationDTO.EndDate;

            await unitOfWork.CommitAsync();
        }
    }

}
