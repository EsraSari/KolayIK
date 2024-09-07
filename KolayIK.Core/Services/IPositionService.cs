using KolayIK.Core.Modal;
using KolayIK.Core.Modal.Idendity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IPositionService
    {
        Task<IEnumerable<Position>> GetAllPositions();
    }
}
