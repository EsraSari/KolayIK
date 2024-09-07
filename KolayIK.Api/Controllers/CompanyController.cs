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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet("GetAllCompanies")]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllCompaniesAsync()
        {
            var companies = await companyService.GetAllCompaniesAsync();
            return Ok(companies);
        }

        [HttpGet("GetCompanyByID/{id}", Name = "GetCompanyById")]
        public async Task<ActionResult<Company>> GetCompanyByIdAsync(int id)
        {
            var company = await companyService.GetCompanyByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [HttpGet("approved")]
        public async Task<ActionResult<IEnumerable<Company>>> GetApprovedCompaniesAsync()
        {
            var approvedCompanies = await companyService.GetApprovedCompaniesAsync();
            return Ok(approvedCompanies);
        }

        [HttpGet("pending")]
        public async Task<ActionResult<IEnumerable<Company>>> GetPendingCompaniesAsync()
        {
            var pendingCompanies = await companyService.GetPendingCompaniesAsync();
            return Ok(pendingCompanies);
        }

        [HttpGet("rejected")]
        public async Task<ActionResult<IEnumerable<Company>>> GetRejectedCompaniesAsync()
        {
            var rejectedCompanies = await companyService.GetRejectedCompaniesAsync();
            return Ok(rejectedCompanies);
        }


        [HttpPost("CreateCompany")]
        public async Task<ActionResult<Company>> CreateCompanyAsync([FromBody] SaveCompanyDTO companyDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdCompany = await companyService.CreateCompanyAsync(companyDTO);

            return CreatedAtRoute("GetCompanyById", new { id = createdCompany.ID }, createdCompany);
        }


        [HttpPut("UpdateCompany/{id}")]
        public async Task<IActionResult> UpdateCompanyAsync(int id, [FromBody] UpdateCompanyDTO updatedCompanyDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var companyToUpdate = await companyService.GetCompanyByIdAsync(id);
            if (companyToUpdate == null)
            {
                return NotFound();
            }

            await companyService.UpdateCompanyAsync(companyToUpdate, updatedCompanyDto);

            return NoContent();
        }


        [HttpDelete("DeleteCompany/{id}")]
        public async Task<IActionResult> DeleteCompanyAsync(int id)
        {
            var result = await companyService.DeleteCompanyAsync(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("GetCompaniesByManagerID/{managerID}")]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompaniesByManagerID(int managerID)
        {
            var companies = await companyService.GetCompaniesByManagerIDAsync(managerID);
            if (companies == null)
            {
                return NotFound();
            }

            return Ok(companies);
        }


    }

}
