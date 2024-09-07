using KolayIK.Core;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IUnitOfWork unitOfWork;
        public EventTypeService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<EventType> GetEventTypeByIdAsync(int id)
        {
            return await unitOfWork.EventTypes.GetByIDAsync(id);
        }
    }
}
