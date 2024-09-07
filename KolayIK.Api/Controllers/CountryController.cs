using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        [HttpGet("GetAllCountries")]
        public async Task<ActionResult<IEnumerable<County>>> GetAllLeaveTypesAsync()
        {
            var countries = await countryService.GetAllCountries();
            return Ok(countries);
        }
        [HttpGet("GetCountryById/{id}")]
        public async Task<ActionResult<Country>> GetCountryByID(int id)
        {
            var city = await countryService.GetCountryById(id);

            if (city == null)
                return NotFound();


            return Ok(city);
        }
    }
}
