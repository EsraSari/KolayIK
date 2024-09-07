using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService cityService;

        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }
        [HttpGet("GetAllCities")]
        public async Task<ActionResult<IEnumerable<City>>> GetAllCitiesAsync()
        {
            var cities = await cityService.GetAllCities();
            return Ok(cities);
        }
        [HttpGet("GetCityById/{id}")]
        public async Task<ActionResult<City>> GetCityByID(int id)
        {
            var city = await cityService.GetCityById(id);

            if (city == null)
                return NotFound();


            return Ok(city);
        }

        [HttpGet("GetAllCitiesByCountryID/{countryID}")]
        public async Task<ActionResult<IEnumerable<LeaveType>>> GetAllCitiesByCountryID(int countryID)
        {
            var cities = await cityService.GetAllCitiesByCountryId(countryID);
            return Ok(cities);
        }
    }
}
