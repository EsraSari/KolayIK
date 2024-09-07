using KolayIK.Core.DTO;
using KolayIK.Core.Modal.Idendity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IRoleService
    {
        Task<IdentityResult> CreateRole(SaveAppRoleDTO roleDTO);
        Task DeleteRole(AppRole role);
        Task<IEnumerable<AppRole>> GetAllRoles();
        Task<AppRole> GetRoleById(int id);
        Task UpdateRole(AppRole roleToBeUpdated, SaveAppRoleDTO newRoleData);
    }
}
