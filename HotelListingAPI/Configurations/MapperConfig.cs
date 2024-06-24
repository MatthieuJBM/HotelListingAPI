using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;
using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Configurations;

public class MapperConfig : Profile
{
    // ctor commend writes a constructor automatically
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap(); // so we can map it in either direction
        CreateMap<Country, GetCountryDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Hotel, HotelDto>().ReverseMap();
    }
}