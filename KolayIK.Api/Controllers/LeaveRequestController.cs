using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestService leaveRequestService;

        public LeaveRequestController(ILeaveRequestService leaveRequestService)
        {
            this.leaveRequestService = leaveRequestService;
        }

        [HttpGet("GetAllLeaveRequests")]
        public async Task<ActionResult<IEnumerable<LeaveRequest>>> GetAllLeaveRequests()
        {
            var leaveRequests = await leaveRequestService.GetAllLeaveRequests();
            return Ok(leaveRequests);
        }

        [HttpGet("GetLeaveReqByID/{id}")]
        public async Task<ActionResult<LeaveRequest>> GetLeaveReqById(int id)
        {
            var leaveRequest = await leaveRequestService.GetLeaveReqById(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return Ok(leaveRequest);
        }

        [HttpGet("GetLeaveReqByEmpID/{employeeId}")]
        public async Task<ActionResult<IEnumerable<LeaveRequest>>> GetLeaveReqByEmpId(int employeeId)
        {
            var leaveRequests = await leaveRequestService.GetLeaveReqByEmpId(employeeId);
            if (leaveRequests == null || !leaveRequests.Any())
            {
                return NotFound();
            }

            return Ok(leaveRequests);
        }

        [HttpPost("CreateLeaveReq")]
        public async Task<ActionResult<LeaveRequest>> CreateLeaveReq([FromBody] SaveLeaveReqDTO leaveReqDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newLeaveRequest = await leaveRequestService.CreateLeaveReq(leaveReqDTO);
            return CreatedAtAction(nameof(GetLeaveReqById), new { id = newLeaveRequest.ID }, newLeaveRequest);
        }

        [HttpPut("UpdateLeaveReq/{id}")]
        public async Task<IActionResult> UpdateLeaveRequest(int id, [FromBody] SaveLeaveReqDTO leaveReqDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingLeaveRequest = await leaveRequestService.GetLeaveReqById(id);
            if (existingLeaveRequest == null)
            {
                return NotFound();
            }

            try
            {
                var updatedLeaveRequest = await leaveRequestService.UpdateLeaveRequest(id, leaveReqDTO);

                if (updatedLeaveRequest == null)
                {
                    return BadRequest("Insufficient remaining leave.");
                }

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("DeleteLeaveReq/{id}")]
        public async Task<IActionResult> DeleteLeaveRequest(int id)
        {
            var leaveRequest = await leaveRequestService.GetLeaveReqById(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            await leaveRequestService.DeleteLeaveRequest(leaveRequest);
            return NoContent();
        }

        [HttpGet("manager/{managerID}")]
        public async Task<IActionResult> GetLeaveRequestsByManagerId(int managerID)
        {
            if (managerID <= 0)
            {
                return BadRequest("Geçersiz yönetici ID.");
            }

            var leaveRequests = await leaveRequestService.GetLeaveRequestsByManagerIdAsync(managerID);

            if (leaveRequests == null)
            {
                return NotFound("İzin talepleri bulunamadı.");
            }

            return Ok(leaveRequests);
        }
    }

}
