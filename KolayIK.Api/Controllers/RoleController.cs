using KolayIK.Core.DTO;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RolesController(IRoleService _roleService)
        {
            roleService = _roleService;
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] SaveAppRoleDTO roleDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await roleService.CreateRole(roleDTO);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok(new { message = "Role created successfully." });
        }

        [HttpDelete("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = await roleService.GetRoleById(id);

            if (role == null)
                return NotFound(new { message = "Role not found." });

            await roleService.DeleteRole(role);
            return Ok(new { message = "Role deleted successfully." });
        }

        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await roleService.GetAllRoles();
            return Ok(roles);
        }

        [HttpGet("GetRoleByID/{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await roleService.GetRoleById(id);

            if (role == null)
                return NotFound(new { message = "Role not found." });

            return Ok(role);
        }

        [HttpPut("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(int id, [FromBody] SaveAppRoleDTO roleDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingRole = await roleService.GetRoleById(id);

            if (existingRole == null)
                return NotFound(new { message = "Role not found." });

            await roleService.UpdateRole(existingRole, roleDTO);
            return Ok(new { message = "Role updated successfully." });
        }
    }

}
