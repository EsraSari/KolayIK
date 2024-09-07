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
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork unitOfWork;
        public CountryService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await unitOfWork.Countries.GetAllAsync();
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await unitOfWork.Countries.GetByIDAsync(id);
        }
    }
}
