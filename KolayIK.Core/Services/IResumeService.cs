using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IResumeService
    {
        Task<Resume> CreateResume(SaveResumeDTO resumeDTO);
        Task<bool> DeleteResume(int id);
        Task<IEnumerable<Resume>> GetAllResumes();
        Task<Resume> GetResumeById(int id);
        Task<Resume> GetResumeByUserId(int userId);
        Task UpdateResume(Resume resumeToBeUpdated, Resume newResumeData);
    }
}
