﻿using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IAddressRepository : IRepository<AddressInfo>
    {
        Task<IEnumerable<AddressInfo>> GetByUserIdAsync(int userId);
        Task<AddressInfo> GetByIDAsync(int id);
        Task<IEnumerable<AddressInfo>> GetAllAsync();
    }
}
