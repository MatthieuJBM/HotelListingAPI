using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data;

/*
 * It is where we're going to be outlining the different tables and setting of different
 * configurations for tables so that when the database is being generated or interacted
 * with, we can have a set of rules or a set of objects outlined here. So this is like
 * a contract between our app and our database.
 */

/*
 * We create an entity class, give it all the properties it needs, and then we just add
 * it to the DB.
 * ;Trusted_Connection=True;MultipleActiveResultSet=True
 */

public class HotelListingDbContext : DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }
}