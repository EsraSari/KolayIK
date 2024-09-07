using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<IEnumerable<Event>> GetAllEvents();
        Task<IEnumerable<Event>> GetCloserEvents();
        Task<IEnumerable<Event>> GetCloserEventsByCompanyID(int companyID);
        Task<IEnumerable<Event>> GetAllEventsByCompanyID(int companyID);

    }
}
