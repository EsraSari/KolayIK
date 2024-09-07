using KolayIK.Core.DTO;
using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser>
    {
        Task<AppUser> GetByEmailAsync(string email);
        Task<IEnumerable<AppUser>> GetAllUsersByManagerIDAsync(int managerID);
        Task<IEnumerable<AppUser>> GetAllUsersByRole(int roleID);
        Task<EmployeeDTO> GetUserWithRoleByUserID(int userID);
    }
}
