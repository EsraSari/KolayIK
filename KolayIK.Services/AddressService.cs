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
        
        private readonly ICountryService countryService;
        private readonly ICountyService countyService;
        private readonly ICityService cityService;

        public AddressService(IUnitOfWork _unitOfWork, ICountryService _countryService, ICountyService _countyService, ICityService _cityService)
        {
            unitOfWork = _unitOfWork;
            countryService = _countryService;
            countyService = _countyService;
        }

        public async Task<AddressInfo> CreateAddressInfo(SaveAddressInfoDTO addressDTO)
        {
            var address = new AddressInfo
            {
                UserID = addressDTO.UserID,
                CountryID = addressDTO.CountryID,
                CityID = addressDTO.CityID,
                CountyID = addressDTO.CountyID,
                AddressDetail = addressDTO.AddressDetail
            };

            await unitOfWork.Addresses.AddAsync(address);
            await unitOfWork.CommitAsync();

            return address;
        }
        public async Task<bool> DeleteAddress(int id)
        {
            var address = await unitOfWork.Addresses.GetByIDAsync(id);

            if (address == null)
                return false;

            unitOfWork.Addresses.Remove(address);
            await unitOfWork.CommitAsync();

            return true;
        }
        public async Task UpdateAddress(AddressInfo addressToBeUpdated, SaveAddressInfoDTO newAddressData)
        {
            addressToBeUpdated.CountryID = newAddressData.CountryID;
            addressToBeUpdated.CityID = newAddressData.CityID;
            addressToBeUpdated.CountyID = newAddressData.CountyID;
            addressToBeUpdated.AddressDetail = newAddressData.AddressDetail;

            await unitOfWork.CommitAsync();
        }
        public async Task<AddressDTO> GetAddressById(int id)
        {
            var address = await unitOfWork.Addresses.GetByIDAsync(id);

            if (address == null)
            {
                return null; 
            }

            var addressDTO = new AddressDTO
            {
                ID = address.ID,
                CountryName = address.Country.CountryName ?? "Bilinmiyor",
                CountyName = address.County.CountyName ?? "Bilinmiyor",
                CityName = address.City.CityName ?? "Bilinmiyor",
                AddressDetail = address.AddressDetail,
                AddedDate = address.AddedDate,
                ModifiedDate = address.ModifiedDate
            };

            return addressDTO;
        }

        public async Task<AddressDTO> GetAddressByUserId(int userId)
        {
            var address = await unitOfWork.Addresses
                .GetByUserIdAsync(userId);

            if (address == null)
            {
                return null;
            }

            var addressDTO = new AddressDTO
            {
                ID = address.ID,
                CountryName = address.Country.CountryName ?? "Bilinmiyor",
                CountyName = address.County.CountyName ?? "Bilinmiyor",   
                CityName = address.City.CityName?? "Bilinmiyor",
                AddressDetail = address.AddressDetail,
                AddedDate = address.AddedDate,
                ModifiedDate = address.ModifiedDate
            };

            return addressDTO;
        }

        public async Task<IEnumerable<AddressDTO>> GetAllAddressInfo()
        {
            var addresses = await unitOfWork.Addresses.GetAllAsync();
            var addressDTOs = new List<AddressDTO>();

            foreach (var address in addresses)
            {

                var addressDTO = new AddressDTO
                {
                    ID = address.ID,
                    CountryName = address.Country.CountryName ?? "Bilinmiyor",
                    CountyName = address.County.CountyName ?? "Bilinmiyor",
                    CityName = address.City.CityName ?? "Bilinmiyor",
                    AddressDetail = address.AddressDetail,
                    AddedDate = address.AddedDate,
                    ModifiedDate = address.ModifiedDate
                };

                addressDTOs.Add(addressDTO);
            }

            return addressDTOs;
        }

    }

}
