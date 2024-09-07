using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationService educationService;

        public EducationController(IEducationService educationService)
        {
            this.educationService = educationService;
        }

        [HttpGet("GetAllEducations")]
        public async Task<ActionResult<IEnumerable<Education>>> GetAllEducations()
        {
            var educations = await educationService.GetAllEducations();
            return Ok(educations);
        }

        [HttpGet("GetEducationById/{id}")]
        public async Task<ActionResult<Education>> GetEducationById(int id)
        {
            var education = await educationService.GetEducationById(id);
            if (education == null)
            {
                return NotFound();
            }

            return Ok(education);
        }

        [HttpGet("GetEducationsByResumeId/{resumeId}")]
        public async Task<ActionResult<IEnumerable<Education>>> GetEducationsByResumeId(int resumeId)
        {
            var educations = await educationService.GetEducationsByResumeId(resumeId);
            if (educations == null || !educations.Any())
            {
                return NotFound();
            }

            return Ok(educations);
        }

        [HttpPost("CreateEducation")]
        public async Task<ActionResult<Education>> CreateEducation([FromBody] SaveEducationDTO educationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newEducation = await educationService.CreateEducation(educationDTO);
            return CreatedAtAction(nameof(GetEducationById), new { id = newEducation.ID }, newEducation);
        }

        [HttpPut("UpdateEducation/{id}")]
        public async Task<IActionResult> UpdateEducation(int id, [FromBody] SaveEducationDTO educationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingEducation = await educationService.GetEducationById(id);
            if (existingEducation == null)
            {
                return NotFound();
            }

            await educationService.UpdateEducation(existingEducation, educationDTO);
            return NoContent();
        }

        [HttpDelete("DeleteEducation/{id}")]
        public async Task<IActionResult> DeleteEducation(int id)
        {
            var education = await educationService.GetEducationById(id);
            if (education == null)
            {
                return NotFound();
            }

            await educationService.DeleteEducation(education);
            return NoContent();
        }
    }

}
