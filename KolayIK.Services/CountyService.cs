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
    public class CountyService : ICountyService
    {
        private readonly IUnitOfWork unitOfWork;
        public CountyService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<County>> GetAllCounties()
        {
            return await unitOfWork.Counties.GetAllAsync();
        }

        public async Task<IEnumerable<County>> GetAllCountiesByCityId(int id)
        {
            return await unitOfWork.Counties.FindAsync(x => x.CityID == id);
        }

        public async Task<County> GetCountyById(int id)
        {
            return await unitOfWork.Counties.GetByIDAsync(id);
        }
    }
}
