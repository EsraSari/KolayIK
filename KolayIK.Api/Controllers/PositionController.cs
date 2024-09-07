using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService positionService;

        public PositionController(IPositionService positionService)
        {
            this.positionService = positionService;
        }
        [HttpGet("GetAllPositions")]
        public async Task<ActionResult<IEnumerable<County>>> GetAllPositionsAsync()
        {
            var positions = await positionService.GetAllPositions();
            return Ok(positions);
        }
    }
}
