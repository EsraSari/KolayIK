using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(KolayIKDBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Event>> GetAllEvents()
        {
            return await KolayIKDBContext.Events
            .Include(e => e.EventType)
            .ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetCloserEvents()
        {
            var oneWeekLater = DateTime.UtcNow.AddDays(7);
            var now = DateTime.UtcNow;

            return await KolayIKDBContext.Events
                .Include(e => e.EventType)
                .Where(e => e.StartDate >= now && e.StartDate <= oneWeekLater)
                .ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetAllEventsByCompanyID(int companyID)
        {
            return await KolayIKDBContext.Events
                .Include(e => e.EventType)
                .Where(e => e.CompanyID == companyID)
                .ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetCloserEventsByCompanyID(int companyID)
        {
            var oneWeekLater = DateTime.UtcNow.AddDays(7);
            var now = DateTime.UtcNow;

            return await KolayIKDBContext.Events
                .Include(e => e.EventType)
                .Where(e => e.CompanyID == companyID && (e.StartDate >= now && e.StartDate <= oneWeekLater))
                .ToListAsync();
        }

        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;

    }
}
