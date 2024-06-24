using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;

namespace HotelListingAPI.Configurations;

public class MapperConfig : Profile
{
    // ctor commend writes a constructor automatically
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap(); // so we can map it in either direction
    }
}