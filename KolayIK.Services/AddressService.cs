using AutoMapper;
using KolayIK.Core;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Services
{
    public class AddressService : IAddressInfoService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public AddressService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<AddressDTO> CreateAddressInfo(SaveAddressInfoDTO saveAddressDTO)
        {
            var address = mapper.Map<AddressInfo>(saveAddressDTO);
            await unitOfWork.Addresses.AddAsync(address);

            var addressDTO = mapper.Map<AddressDTO>(address);
            return addressDTO;
        }
        public async Task<bool> DeleteAddress(int id)
        {
            var address = await unitOfWork.Addresses.GetByIDAsync(id);

            if (address == null)
                return false;

            address.Status = false;
            address.ModifiedDate = DateTime.Now;
            await unitOfWork.CommitAsync();
            return true;
        }
        public async Task<bool> UpdateAddress(AddressInfo addressToBeUpdated, SaveAddressInfoDTO newAddressData)
        {
            addressToBeUpdated.CountryID = newAddressData.CountryID;
            addressToBeUpdated.CityID = newAddressData.CityID;
            addressToBeUpdated.CountyID = newAddressData.CountyID;
            addressToBeUpdated.AddressDetail = newAddressData.AddressDetail;
            addressToBeUpdated.ModifiedDate = DateTime.Now;
            await unitOfWork.CommitAsync();
            return true;
        }
        public async Task<AddressDTO> GetAddressById(int id)
        {
            var address = await unitOfWork.Addresses.GetByIDAsync(id);
            if (address == null)
            {
                return null; 
            }
            var addressDTO = mapper.Map<AddressDTO>(address);
            return addressDTO;
        }
        public async Task<IEnumerable<AddressDTO>> GetAddressByUserId(int userId)
        {
            var addresses = await unitOfWork.Addresses
                .GetByUserIdAsync(userId);
            if (addresses == null)
                return null;

            var addressDTOs = mapper.Map<List<AddressDTO>>(addresses);
            return addressDTOs;
        }
        public async Task<IEnumerable<AddressDTO>> GetAllAddressInfo()
        {
            var addresses = await unitOfWork.Addresses.GetAllAsync();
            var addressDTOs = new List<AddressDTO>();

            foreach (var address in addresses)
            {
                var addressDTO = mapper.Map<AddressDTO>(address);
                addressDTOs.Add(addressDTO);
            }
            return addressDTOs;
        }

    }

}
