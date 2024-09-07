using KolayIK.Core;
using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using KolayIK.Core.Services;
using KolayIK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork unitOfWork;

        public StateService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<IEnumerable<State>> GetAllStates()
        {
            return await unitOfWork.States.GetAllAsync();
        }

    }

}
