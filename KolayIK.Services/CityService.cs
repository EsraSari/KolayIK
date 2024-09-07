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
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        public CityService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<City>> GetAllCities()
        {
            return await unitOfWork.Cities.GetAllAsync();
        }

        public async Task<IEnumerable<City>> GetAllCitiesByCountryId(int id)
        {
            return await unitOfWork.Cities.FindAsync(x => x.CountryID == id);
        }

        public async Task<City> GetCityById(int id)
        {
            return await unitOfWork.Cities.GetByIDAsync(id);
        }
        
    }
}
