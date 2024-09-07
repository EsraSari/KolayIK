using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class EventTypeRepository : Repository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(KolayIKDBContext context) : base(context)
        {

        }

        public async Task<EventType> GetByIDAsync(int id)
        {
            return await KolayIKDBContext.EventTypes.FindAsync(id);
        }
        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
