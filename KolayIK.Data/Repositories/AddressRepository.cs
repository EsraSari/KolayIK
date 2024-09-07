using KolayIK.Core.Modal;
using KolayIK.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Data.Repositories
{
    public class AddressRepository : Repository<AddressInfo>, IAddressRepository
    {
        public AddressRepository(KolayIKDBContext context) : base(context)
        {
        }

        public async Task<AddressInfo> GetByUserIdAsync(int userId)
        {
            return await KolayIKDBContext.AddressInfos
                .Include(r => r.City)
                .Include(r => r.Country)
                .Include(r => r.County)
                .FirstOrDefaultAsync(r => r.UserID == userId);
        }
        public async Task<AddressInfo> GetByIDAsync(int id)
        {
            return await KolayIKDBContext.AddressInfos
                .Include(r => r.City)
                .Include(r => r.Country)
                .Include(r => r.County)
                .FirstOrDefaultAsync(r => r.ID == id);
        }
        public async Task<IEnumerable<AddressInfo>> GetAllAsync()
        {
            return await KolayIKDBContext.AddressInfos
                .Include(r => r.City)
                .Include(r => r.Country)
                .Include(r => r.County)
                .ToListAsync();
        }
        private KolayIKDBContext KolayIKDBContext => Context as KolayIKDBContext;
    }
}
