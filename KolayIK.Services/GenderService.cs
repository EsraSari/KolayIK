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
    public class GenderService : IGenderService
    {
        private readonly IUnitOfWork unitOfWork;
        public GenderService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<Gender>> GetAllGenders()
        {
            return await unitOfWork.Genders.GetAllAsync();
        }
    }
}
