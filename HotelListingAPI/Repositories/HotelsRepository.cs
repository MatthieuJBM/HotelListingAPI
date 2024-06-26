using HotelListingAPI.Contracts;
using HotelListingAPI.Data;

namespace HotelListingAPI.Repositories;

public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
{
    public HotelsRepository(HotelListingDbContext context) : base(context)
    {
    }
}