using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountyController : ControllerBase
    {
        private readonly ICountyService countyService;

        public CountyController(ICountyService countyService)
        {
            this.countyService = countyService;
        }
        [HttpGet("GetAllCounties")]
        public async Task<ActionResult<IEnumerable<County>>> GetAllCountyAsync()
        {
            var counties = await countyService.GetAllCounties();
            return Ok(counties);
        }
        [HttpGet("GetCountyById/{id}")]
        public async Task<ActionResult<County>> GetCountyByID(int id)
        {
            var city = await countyService.GetCountyById(id);

            if (city == null)
                return NotFound();


            return Ok(city);
        }

        [HttpGet("GetAllCountiesByCityID/{cityID}")]
        public async Task<ActionResult<IEnumerable<County>>> GetAllCitiesByCountryID(int cityID)
        {
            var cities = await countyService.GetAllCountiesByCityId(cityID);
            return Ok(cities);
        }
    }
}
