using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService stateService;
        public StateController(IStateService stateService)
        {
            this.stateService = stateService;
        }
        [HttpGet("GetAllStates")]
        public async Task<ActionResult<IEnumerable<State>>> GetAllStatesAsync()
        {
            var states = await stateService.GetAllStates();
            return Ok(states);
        }
    }
}
