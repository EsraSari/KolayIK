using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface ICountyService
    {
        Task<IEnumerable<County>> GetAllCounties();
        Task<County> GetCountyById(int id);
        Task<IEnumerable<County>> GetAllCountiesByCityId(int id);
    }
}
