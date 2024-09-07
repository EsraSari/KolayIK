using KolayIK.Core.DTO;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyPersonController : ControllerBase
    {
        private readonly IEmergencyPersonService epService;

        public EmergencyPersonController(IEmergencyPersonService epService)
        {
            this.epService = epService;
        }

        [HttpGet("GetEPByID/{id}")]
        public async Task<IActionResult> GetEmergencyPersonByIdAsync(int id)
        {
            var emergencyPerson = await epService.GetEmergencyPersonByIdAsync(id);
            if (emergencyPerson == null)
            {
                return NotFound();
            }
            return Ok(emergencyPerson);
        }

        [HttpGet("GetAllEP")]
        public async Task<IActionResult> GetAllEmergencyPersonsAsync()
        {
            var emergencyPersons = await epService.GetAllEmergencyPersonAsync();
            return Ok(emergencyPersons);
        }

        [HttpGet("GetAllEPByEmployeeID/{employeeID}")]
        public async Task<IActionResult> GetEmergecyPersonByEmployeeIDAsync(int employeeID)
        {
            var emergencyPerson = await epService.GetEmergecyPersonByEmployeeIDAsync(employeeID);
            if (emergencyPerson == null)
            {
                return NotFound();
            }
            return Ok(emergencyPerson);
        }

        [HttpPost("CreateEP")]
        public async Task<IActionResult> CreateEmergencyPersonAsync([FromBody] SaveEmergencyPersonDTO saveEmergencyPersonDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdEmergencyPerson = await epService.CreateEmergencyPersonAsync(saveEmergencyPersonDTO);
            return Ok(createdEmergencyPerson);
        }

        [HttpPut("UpdateEP/{id}")]
        public async Task<IActionResult> UpdateEmergencyPersonAsync(int id, [FromBody] SaveEmergencyPersonDTO updatedEmergencyPersonDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await epService.UpdateEmergencyPersonAsync(id, updatedEmergencyPersonDTO);
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmergencyPersonAsync(int id)
        {
            var emergencyPerson = await epService.GetEmergencyPersonByIdAsync(id);
            if (emergencyPerson == null)
            {
                return NotFound();
            }   

            await epService.DeleteEmergencyPersonAsync(id);
            return NoContent();
        }
    }
}
