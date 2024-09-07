using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseRequestController : ControllerBase
    {
        private readonly IExpenseRequestService expenseRequestService;

        public ExpenseRequestController(IExpenseRequestService expenseRequestService)
        {
            this.expenseRequestService = expenseRequestService;
        }

        [HttpGet("GetAllExpenseReq")]
        public async Task<ActionResult<IEnumerable<ExpenseRequest>>> GetAllExpenseRequests()
        {
            var expenseRequests = await expenseRequestService.GetAllExpenseRequests();
            return Ok(expenseRequests);
        }

        [HttpGet("GetExpenseReqByID/{id}")]
        public async Task<ActionResult<ExpenseRequest>> GetExpenseReqById(int id)
        {
            var expenseRequest = await expenseRequestService.GetExpenseReqById(id);
            if (expenseRequest == null)
            {
                return NotFound();
            }

            return Ok(expenseRequest);
        }

        [HttpGet("GetExpenseReqByEmpID/{employeeId}")]
        public async Task<ActionResult<IEnumerable<ExpenseRequest>>> GetExpenseReqByEmpId(int employeeId)
        {
            var expenseRequests = await expenseRequestService.GetExpenseReqByEmpId(employeeId);
            if (expenseRequests == null || !expenseRequests.Any())
            {
                return NotFound();
            }

            return Ok(expenseRequests);
        }

        [HttpPost("CreateExpenseReq")]
        public async Task<ActionResult<ExpenseRequest>> CreateExpenseReq([FromBody] SaveExpenseReqDTO expenseReqDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newExpenseRequest = await expenseRequestService.CreateExpenseReq(expenseReqDTO);
            return CreatedAtAction(nameof(GetExpenseReqById), new { id = newExpenseRequest.ID }, newExpenseRequest);
        }

        [HttpPut("UpdateExpenseReq/{id}")]
        public async Task<IActionResult> UpdateExpenseRequest(int id, [FromBody] SaveExpenseReqDTO expenseReq)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await expenseRequestService.UpdateExpenseRequest(id, expenseReq);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("DeleteExpenseReq/{id}")]
        public async Task<IActionResult> DeleteExpenseRequest(int id)
        {
            var expenseRequest = await expenseRequestService.GetExpenseReqById(id);
            if (expenseRequest == null)
            {
                return NotFound();
            }

            await expenseRequestService.DeleteExpenseRequest(expenseRequest.ID);
            return NoContent();
        }

        [HttpGet("manager/{managerID}")]
        public async Task<IActionResult> GetExpenseRequestsByManagerId(int managerID)
        {
            if (managerID <= 0)
            {
                return BadRequest("Geçersiz yönetici ID.");
            }

            var expensseRequests = await expenseRequestService.GetExpenseRequestsByManagerIdAsync(managerID);

            if (expensseRequests == null)
            {
                return NotFound("Masraf talepleri bulunamadı.");
            }

            return Ok(expensseRequests);
        }
    }

}
