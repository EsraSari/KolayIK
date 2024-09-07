using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceService experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            this.experienceService = experienceService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetAllExperiences()
        {
            var experiences = await experienceService.GetAllExperiences();
            return Ok(experiences);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Experience>> GetExperienceById(int id)
        {
            var experience = await experienceService.GetExperienceById(id);
            if (experience == null)
            {
                return NotFound();
            }

            return Ok(experience);
        }

        [HttpGet("resume/{resumeId}")]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperiencesByResumeId(int resumeId)
        {
            var experiences = await experienceService.GetExperiencesByResumeId(resumeId);
            if (experiences == null || !experiences.Any())
            {
                return NotFound();
            }

            return Ok(experiences);
        }

        [HttpPost]
        public async Task<ActionResult<Experience>> CreateExperience([FromBody] SaveExperienceDTO experienceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newExperience = await experienceService.CreateExperience(experienceDTO);
            return CreatedAtAction(nameof(GetExperienceById), new { id = newExperience.ID }, newExperience);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExperience(int id, [FromBody] SaveExperienceDTO experienceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingExperience = await experienceService.GetExperienceById(id);
            if (existingExperience == null)
            {
                return NotFound();
            }

            await experienceService.UpdateExperience(existingExperience, experienceDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperience(int id)
        {
            var experience = await experienceService.GetExperienceById(id);
            if (experience == null)
            {
                return NotFound();
            }

            await experienceService.DeleteExperience(experience);
            return NoContent();
        }
    }

}
