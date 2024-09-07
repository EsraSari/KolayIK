using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllCities();
        Task<City> GetCityById(int id);
        Task<IEnumerable<City>> GetAllCitiesByCountryId(int id);
    }
}
