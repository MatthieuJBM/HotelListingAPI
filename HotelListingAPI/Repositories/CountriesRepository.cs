using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Repositories;

public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
{
    /*
     * Once you're doing inheritance, the GenericRepository requires the DbContext to be injected
     * into it. Then whatever is calling it needs to take a copy of that and pass it down
     * to the base.
     */

    private readonly HotelListingDbContext _context;
    public CountriesRepository(HotelListingDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Country> GetDetails(int id)
    {
        return await _context.Countries.Include(q => q.Hotels)
            .FirstOrDefaultAsync(q => q.Id == id);
    }
}