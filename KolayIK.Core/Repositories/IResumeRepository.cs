using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IResumeRepository : IRepository<Resume>
    {
        Task<Resume> GetByUserIdAsync(int userId);
        Task<Resume> GetByIDAsync(int id);
        Task<IEnumerable<Resume>> GetAllAsync();
    }
}
