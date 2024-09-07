using KolayIK.Core;
using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using KolayIK.Core.Services;
using KolayIK.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly IUnitOfWork unitOfWork;
        public LeaveTypeService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<LeaveType>> GetAllLeaveTypes()
        {
            return await unitOfWork.LeaveTypes.GetAllAsync();
        }

    }
}
