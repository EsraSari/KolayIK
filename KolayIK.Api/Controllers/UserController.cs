using AutoMapper;
using KolayIK.Api.Validators;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using KolayIK.Data;
using KolayIK.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public UserController(IUserService _userService, IMapper _mapper)
        {
            userService = _userService;
            mapper = _mapper;
        }

        [HttpGet("GelAllUsers")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await userService.GetAllUsers();

            var userResources = mapper.Map<IEnumerable<AppUser>, IEnumerable<UserDTO>>(users);
            return Ok(userResources);
        }

        [HttpGet("GetUserByID/{id}")]
        public async Task<ActionResult<UserDTO>> GetUserByID(int id)
        {
            var user = await userService.GetUserById(id);

            if (user == null)
                return NotFound();

            var userResources = mapper.Map<AppUser, UserDTO>(user);

            return Ok(userResources);
        }

        //[Authorize(Roles = "Admin, Manager")]
        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] SaveUserDTO user)
        {
            var validator = new SaveUserValidator();
            var validatorResult = await validator.ValidateAsync(user);

            if (!validatorResult.IsValid)
                return BadRequest(validatorResult.Errors);

            var createUserResult = await userService.CreateUser(user);

            if (!createUserResult.Succeeded)
            {
                var errors = createUserResult.Errors.Select(e => new { e.Code, e.Description });
                return BadRequest(errors);
            }

            var relatedUser = await userService.GetUserByEmail(user.Email);
            if (relatedUser == null)
            {
                return NotFound();
            }

            return Ok(relatedUser);
        }


        [HttpPost("Authenticate")]
        public async Task<IActionResult> AuthenticateUser([FromBody] LoginDTO login)
        {
            var userWithRoles = await userService.AuthenticateUser(login.Email, login.Password);

            if (userWithRoles == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new
            {
                message = "Authentication successful",
                user = userWithRoles.User,
                roles = userWithRoles.Roles
            });
        }

        [HttpGet("GetAllUsersByManagerID/{managerID}")]
        public async Task<IActionResult> GetAllUsersByManagerID(int managerID)
        {
            var users = await userService.GetAllUsersByManagerIDAsync(managerID);
            if (users == null || !users.Any())
            {
                return NotFound("No users found for the given manager ID.");
            }
            return Ok(users);
        }

        [HttpGet("GetAllUsersByRoleID/{roleID}")]
        public async Task<IActionResult> GetAllUsersByRoleID(int roleID)
        {
            var users = await userService.GetAllUsersByRole(roleID);
            if (users == null || !users.Any())
            {
                return NotFound("No users found for the given ROLE ID.");
            }
            return Ok(users);
        }

        [HttpGet("GetUserWithRoleByUserID/{userID}")]
        public async Task<IActionResult> GetUserWithRoleByUserID(int userID)
        {
            var user = await userService.GetUserWithRoleByUserID(userID);
            if (user == null)
            {
                return NotFound("No user found for the given userID.");
            }
            return Ok(user);
        }

        [HttpPut("UpdateUser/{userId}")]
        public async Task<ActionResult> UpdateUser(int userId, [FromBody] SaveUserDTO newUser)
        {
            var user = await userService.GetUserById(userId);
            if (user == null)
            {
                return NotFound($"User with ID {userId} not found.");
            }

            var updateResult = await userService.UpdateUser(user, newUser);

            if (updateResult == null)
            {
                return BadRequest();
            }

            return Ok(updateResult);
        }

    }
}
