﻿using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Services
{
    public interface IAddressInfoService
    {
        Task<AddressInfo> CreateAddressInfo(SaveAddressInfoDTO addressDTO);
        Task<bool> DeleteAddress(int id);
        Task<IEnumerable<AddressDTO>> GetAllAddressInfo();
        Task<AddressDTO> GetAddressById(int id);
        Task<AddressDTO> GetAddressByUserId(int userId);
        Task UpdateAddress (AddressInfo addressToBeUpdated, SaveAddressInfoDTO newAddressData);
    }
}
