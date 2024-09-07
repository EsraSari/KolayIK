using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork unitOfWork;

        public EventService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<IEnumerable<EventDTO>> GetAllEvents()
        {
            var events = await unitOfWork.Events
                .GetAllEvents();

            var eventDtos = new List<EventDTO>();
            foreach (var ev in events)
            {
                var dto = new EventDTO
                {
                    Id = ev.ID,
                    EventName = ev.EventName,
                    StartDate = ev.StartDate,
                    EndDate = ev.EndDate,
                    EventType = ev.EventType.EventTypeName ?? "Belirtilmedi",
                    AddedDate = ev.AddedDate,
                    ModifiedDate = ev.ModifiedDate
                };

                eventDtos.Add(dto);
            }

            return eventDtos;

        }

        public async Task<IEnumerable<EventDTO>> GetCloserEvents()
        {
            var events = await unitOfWork.Events
                .GetCloserEvents();

            var eventDtos = new List<EventDTO>();
            foreach (var ev in events)
            {
                var dto = new EventDTO
                {
                    Id = ev.ID,
                    EventName = ev.EventName,
                    StartDate = ev.StartDate,
                    EndDate = ev.EndDate,
                    EventType = ev.EventType.EventTypeName ?? "Belirtilmedi",
                    AddedDate = ev.AddedDate,
                    ModifiedDate = ev.ModifiedDate
                };

                eventDtos.Add(dto);
            }

            return eventDtos;
        }

        public async Task<IEnumerable<EventDTO>> GetCloserEventsByCompanyID(int companyID)
        {
            var events = await unitOfWork.Events
                .GetCloserEventsByCompanyID(companyID);

            var eventDtos = new List<EventDTO>();
            foreach (var ev in events)
            {
                var dto = new EventDTO
                {
                    Id = ev.ID,
                    EventName = ev.EventName,
                    StartDate = ev.StartDate,
                    EndDate = ev.EndDate,
                    EventType = ev.EventType.EventTypeName ?? "Belirtilmedi",
                    AddedDate = ev.AddedDate,
                    ModifiedDate = ev.ModifiedDate
                };

                eventDtos.Add(dto);
            }

            return eventDtos;
        }

        public async Task<IEnumerable<EventDTO>> GetAllEventsByCompanyID(int companyID)
        {
            var events = await unitOfWork.Events
                .GetAllEventsByCompanyID(companyID);

            var eventDtos = new List<EventDTO>();
            foreach (var ev in events)
            {
                var dto = new EventDTO
                {
                    Id = ev.ID,
                    EventName = ev.EventName,
                    StartDate = ev.StartDate,
                    EndDate = ev.EndDate,
                    EventType = ev.EventType.EventTypeName ?? "Belirtilmedi",
                    AddedDate = ev.AddedDate,
                    ModifiedDate = ev.ModifiedDate
                };

                eventDtos.Add(dto);
            }

            return eventDtos;
        }
    }
}
