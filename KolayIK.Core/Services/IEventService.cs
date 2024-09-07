using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetAllEvents();
        Task<IEnumerable<EventDTO>> GetCloserEvents();
        Task<IEnumerable<EventDTO>> GetCloserEventsByCompanyID(int companyID);
        Task<IEnumerable<EventDTO>> GetAllEventsByCompanyID(int companyID);
    }
}
