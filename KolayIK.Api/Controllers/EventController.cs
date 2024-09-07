using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using KolayIK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet("GetAllEvents")]
        public async Task<ActionResult<IEnumerable<Event>>> GetAllEvents()
        {
            var events = await eventService.GetAllEvents();
            return Ok(events);
        }
        [HttpGet("GetAllEventsByCompanyID/{companyID}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetAllEventsByCompanyID(int companyID)
        {
            var events = await eventService.GetAllEventsByCompanyID(companyID);
            return Ok(events);
        }
        [HttpGet("GetCloserEvents")]
        public async Task<ActionResult<IEnumerable<Event>>> GetCloserEvents()
        {
            var events = await eventService.GetCloserEvents();
            return Ok(events);
        }
        [HttpGet("GetCloserEventsByCompanyID/{companyID}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetCloserEventsByCompanyID(int companyID)
        {
            var events = await eventService.GetCloserEventsByCompanyID(companyID);
            return Ok(events);
        }
    }
}
