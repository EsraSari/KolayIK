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
    public class ResumeService : IResumeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IExperienceService experienceService;
        private readonly IEducationService educationService;
        private readonly ICertificateService certificateService;

        public ResumeService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<Resume> CreateResume(SaveResumeDTO resumeDTO)
        {
            var newResume = new Resume
            {
                UserID = resumeDTO.UserID,
                Summary = resumeDTO.Summary,
                Skills = resumeDTO.Skills
            };

            await unitOfWork.Resumes.AddAsync(newResume);
            await unitOfWork.CommitAsync();

            var resumeID = newResume.ID;

            foreach (var experienceDTO in resumeDTO.WorkExperiences)
            {
                var experience = new Experience
                {
                    CompanyName = experienceDTO.CompanyName,
                    StartDate = experienceDTO.StartDate,
                    EndDate = experienceDTO.EndDate,
                    PositionID = experienceDTO.PositionID,
                    ResumeID = resumeID
                };

                await unitOfWork.Experiences.AddAsync(experience);
            }

            foreach (var educationDTO in resumeDTO.Educations)
            {
                var education = new Education
                {
                    SchoolName = educationDTO.SchoolName,
                    StartDate = educationDTO.StartDate,
                    EndDate = educationDTO.EndDate,
                    ResumeID = resumeID
                };

                await unitOfWork.Educations.AddAsync(education);
            }

            foreach (var certificateDTO in resumeDTO.Certificates)
            {
                var certificate = new Certificate
                {
                    Name = certificateDTO.Name,
                    IssuedBy = certificateDTO.IssuedBy,
                    IssueDate = certificateDTO.IssueDate,
                    ExpiryDate = certificateDTO.ExpiryDate,
                    Description = certificateDTO.Description,
                    ResumeID = resumeID
                };

                await unitOfWork.Certificates.AddAsync(certificate);
            }

            await unitOfWork.CommitAsync();

            return newResume;
        }

        public async Task<bool> DeleteResume(int resumeId)
        {
            var resume = await unitOfWork.Resumes.GetByIDAsync(resumeId);
            if (resume == null)
            {
                return false;
            }

            unitOfWork.Resumes.Remove(resume);
            await unitOfWork.CommitAsync();
            return true;
        }


        public async Task<IEnumerable<Resume>> GetAllResumes()
        {
            return await unitOfWork.Resumes.GetAllAsync();
        }

        public async Task<Resume> GetResumeById(int id)
        {
            return await unitOfWork.Resumes.GetByIDAsync(id);
        }

        public async Task UpdateResume(Resume resumeToBeUpdated, Resume newResumeData)
        {
            resumeToBeUpdated.Summary = newResumeData.Summary;
            resumeToBeUpdated.Skills = newResumeData.Skills;
            resumeToBeUpdated.WorkExperiences = newResumeData.WorkExperiences;
            resumeToBeUpdated.Educations = newResumeData.Educations;
            resumeToBeUpdated.Certificates = newResumeData.Certificates;

            await unitOfWork.CommitAsync();
        }

        public async Task<Resume> GetResumeByUserId(int userId)
        {
            return await unitOfWork.Resumes.GetByUserIdAsync(userId);
        }

    }
}
