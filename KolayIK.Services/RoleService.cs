using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly RoleManager<AppRole> roleManager;

        public RoleService(IUnitOfWork _unitOfWork, RoleManager<AppRole> _roleManager)
        {
            unitOfWork = _unitOfWork;
            roleManager = _roleManager;
        }

        public async Task<IdentityResult> CreateRole(SaveAppRoleDTO roleDTO)
        {
            var newRole = new AppRole
            {
                Name = roleDTO.Name
            };

            var result = await roleManager.CreateAsync(newRole);

            if (result.Succeeded)
            {
                await unitOfWork.CommitAsync();
            }

            return result;
        }

        public async Task DeleteRole(AppRole role)
        {
            var result = await roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                await unitOfWork.CommitAsync();
            }
        }

        public async Task<IEnumerable<AppRole>> GetAllRoles()
        {
            return await unitOfWork.Roles.GetAllAsync();
        }

        public async Task<AppRole> GetRoleById(int id)
        {
            return await unitOfWork.Roles.GetByIDAsync(id);
        }

        public async Task UpdateRole(AppRole roleToBeUpdated, SaveAppRoleDTO newRoleData)
        {
            roleToBeUpdated.Name = newRoleData.Name;

            var result = await roleManager.UpdateAsync(roleToBeUpdated);

            if (result.Succeeded)
            {
                await unitOfWork.CommitAsync();
            }
        }
    }

}
