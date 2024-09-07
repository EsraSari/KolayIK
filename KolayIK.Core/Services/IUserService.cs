using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<AppUser>> GetAllUsers();
        Task<AppUser> GetUserById(int id);
        Task<IdentityResult> CreateUser(SaveUserDTO user);
        Task<AppUser> UpdateUser(AppUser userToBeUpdated, SaveUserDTO newUser);
        Task DeleteUser(AppUser user);
        Task<AppUser> GetUserByEmail(string email);
        Task<AppUserWithRolesDTO> AuthenticateUser(string email, string password);
        Task<IEnumerable<EmployeeDTO>> GetAllUsersByManagerIDAsync(int managerID);
        Task<IEnumerable<EmployeeDTO>> GetAllUsersByRole(int roleID);
        Task<EmployeeDTO> GetUserWithRoleByUserID(int userID);
    }
}
