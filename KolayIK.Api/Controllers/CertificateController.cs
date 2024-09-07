using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateService certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            this.certificateService = certificateService;
        }

        [HttpGet("GetAllCertificates")]
        public async Task<ActionResult<IEnumerable<Certificate>>> GetAllCertificates()
        {
            var certificates = await certificateService.GetAllCertificates();
            return Ok(certificates);
        }

        [HttpGet("GetCertificateById/{id}")]
        public async Task<ActionResult<Certificate>> GetCertificateById(int id)
        {
            var certificate = await certificateService.GetCertificateById(id);
            if (certificate == null)
            {
                return NotFound();
            }

            return Ok(certificate);
        }

        [HttpGet("GetCertificatesByResumeId/{resumeId}")]
        public async Task<ActionResult<IEnumerable<Certificate>>> GetCertificatesByResumeId(int resumeId)
        {
            var certificates = await certificateService.GetCertificatesByResumeId(resumeId);
            if (certificates == null || !certificates.Any())
            {
                return NotFound();
            }

            return Ok(certificates);
        }

        [HttpPost("CreateCertificate")]
        public async Task<ActionResult<Certificate>> CreateCertificate([FromBody] SaveCertificateDTO certificateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCertificate = await certificateService.CreateCertificate(certificateDTO);
            return CreatedAtAction(nameof(GetCertificateById), new { id = newCertificate.ID }, newCertificate);
        }

        [HttpPut("UpdateCertificate/{id}")]
        public async Task<IActionResult> UpdateCertificate(int id, [FromBody] SaveCertificateDTO certificateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCertificate = await certificateService.GetCertificateById(id);
            if (existingCertificate == null)
            {
                return NotFound();
            }

            await certificateService.UpdateCertificate(existingCertificate, certificateDTO);
            return NoContent();
        }

        [HttpDelete("DeleteCertificate/{id}")]
        public async Task<IActionResult> DeleteCertificate(int id)
        {
            var certificate = await certificateService.GetCertificateById(id);
            if (certificate == null)
            {
                return NotFound();
            }

            await certificateService.DeleteCertificate(certificate);
            return NoContent();
        }
    }

}
