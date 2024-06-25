using HotelListingAPI.Contracts;
using HotelListingAPI.Data;

namespace HotelListingAPI.Repositories;

public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
{
    /*
     * Once you're doing inheritance, the GenericRepository requires the DbContext to be injected
     * into it. Then whatever is calling it needs to take a copy of that and pass it down
     * to the base.
     */
    public CountriesRepository(HotelListingDbContext context) : base(context)
    {
        
    }
}