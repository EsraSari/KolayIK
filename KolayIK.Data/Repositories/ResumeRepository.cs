using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class ResumeRepository : Repository<Resume>, IResumeRepository
    {
        public ResumeRepository(KolayIKDBContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Resume>> GetAllAsync()
        {
            return await KolayIKDBContext.Resumes
                .Include(r => r.Certificates)
                .Include(r => r.WorkExperiences)
                .Include(r => r.Educations)
                .ToListAsync();
        }
        public async Task<Resume> GetByUserIdAsync(int userId)
        {
            return await KolayIKDBContext.Resumes
                .Include(r => r.Certificates)
                .Include(r => r.WorkExperiences)
                .Include(r => r.Educations)
                .FirstOrDefaultAsync(r => r.UserID == userId);
        }
        public async Task<Resume> GetByIDAsync(int id)
        {
            return await KolayIKDBContext.Resumes
                .Include(r => r.Certificates)
                .Include(r => r.WorkExperiences)
                .Include(r => r.Educations)
                .FirstOrDefaultAsync(r => r.ID == id);
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
