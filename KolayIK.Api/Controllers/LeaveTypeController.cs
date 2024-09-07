using AutoMapper;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly ILeaveTypeService leaveTypeService;

        public LeaveTypeController(ILeaveTypeService leaveTypeService)
        {
            this.leaveTypeService = leaveTypeService;
        }
        [HttpGet("GetAllLeaveTypes")]
        public async Task<ActionResult<IEnumerable<LeaveType>>> GetAllLeaveTypesAsync()
        {
            var leaveTypes = await leaveTypeService.GetAllLeaveTypes();
            return Ok(leaveTypes);
        }
    }
}
