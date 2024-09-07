using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService resumeService;

        public ResumeController(IResumeService resumeService)
        {
            this.resumeService = resumeService;
        }

        [HttpGet("GetAllResumes")]
        public async Task<ActionResult<IEnumerable<Resume>>> GetAllResumes()
        {
            var resumes = await resumeService.GetAllResumes();
            return Ok(resumes);
        }

        [HttpGet("GetResumeById/{id}")]
        public async Task<ActionResult<Resume>> GetResumeById(int id)
        {
            var resume = await resumeService.GetResumeById(id);
            if (resume == null)
            {
                return NotFound();
            }

            return Ok(resume);
        }

        [HttpGet("GetResumeByUserId/{userId}")]
        public async Task<ActionResult<Resume>> GetResumeByUserId(int userId)
        {
            var resumes = await resumeService.GetResumeByUserId(userId);
            if (resumes == null)
            {
                return NotFound();
            }

            return Ok(resumes);
        }

        [HttpPost("CreateResume")]
        public async Task<ActionResult<Resume>> CreateResume([FromBody] SaveResumeDTO resumeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newResume = await resumeService.CreateResume(resumeDTO);
            return CreatedAtAction(nameof(GetResumeById), new { id = newResume.ID }, newResume);
        }


        [HttpPut("UpdateResume/{id}")]
        public async Task<ActionResult> UpdateResume(int id, [FromBody] SaveResumeDTO resumeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resumeToBeUpdated = await resumeService.GetResumeById(id);
            if (resumeToBeUpdated == null)
            {
                return NotFound();
            }

            var updatedResume = new Resume
            {
                ID = id,
                Summary = resumeDTO.Summary,
                Skills = resumeDTO.Skills,
                WorkExperiences = resumeDTO.WorkExperiences.Select(we => new Experience
                {
                    CompanyName = we.CompanyName,
                    StartDate = we.StartDate,
                    EndDate = we.EndDate,
                    PositionID = we.PositionID,
                    ResumeID = id
                }).ToList(),
                Educations = resumeDTO.Educations.Select(e => new Education
                {
                    SchoolName = e.SchoolName,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    ResumeID = id
                }).ToList(),
                Certificates = resumeDTO.Certificates.Select(c => new Certificate
                {
                    Name = c.Name,
                    IssuedBy = c.IssuedBy,
                    IssueDate = c.IssueDate,
                    ExpiryDate = c.ExpiryDate,
                    Description = c.Description,
                    ResumeID = id
                }).ToList()
            };

            await resumeService.UpdateResume(resumeToBeUpdated, updatedResume);
            return NoContent();
        }



        [HttpDelete("DeleteResume/{id}")]
        public async Task<IActionResult> DeleteResume(int id)
        {
            var result = await resumeService.DeleteResume(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

    }

}
