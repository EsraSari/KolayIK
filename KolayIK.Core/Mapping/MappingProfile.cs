using AutoMapper;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddressInfo, AddressDTO>()
           .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.CountryName ?? "Bilinmiyor"))
           .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.CityName ?? "Bilinmiyor"))
           .ForMember(dest => dest.CountyName, opt => opt.MapFrom(src => src.County.CountyName ?? "Bilinmiyor"))
           .ReverseMap();


            CreateMap<SaveAddressInfoDTO, AddressInfo>().ReverseMap();

        }
    }
}
