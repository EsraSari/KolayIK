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
    public class PositionService : IPositionService
    {
        private readonly IUnitOfWork unitOfWork;

        public PositionService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<Position>> GetAllPositions()
        {
            return await unitOfWork.Positions.GetAllAsync();
        }
    }
}
