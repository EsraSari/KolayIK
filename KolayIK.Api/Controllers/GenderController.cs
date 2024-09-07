using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IGenderService genderService;

        public GenderController(IGenderService genderService)
        {
            this.genderService = genderService;
        }
        [HttpGet("GetAllGenders")]
        public async Task<ActionResult<IEnumerable<Gender>>> GetAllGendersAsync()
        {
            var genders = await genderService.GetAllGenders();
            return Ok(genders);
        }
    }
}
