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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Jamaica",
                ShortName = "JM",
            },
            new Country
            {
                Id = 2,
                Name = "Bahamas",
                ShortName = "BS",
            },
            new Country
            {
                Id = 3,
                Name = "Cayman Island",
                ShortName = "CI",
            }
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Sandals Resort and Spa",
                Address = "Negril",
                CountryId = 1,
                Rating = 4.5,
            },
            new Hotel
            {
                Id = 2,
                Name = "Comfort Suites",
                Address = "George Town",
                CountryId = 3,
                Rating = 4.3,
            },
            new Hotel
            {
                Id = 3,
                Name = "Grand Palldium",
                Address = "Nassua",
                CountryId = 2,
                Rating = 4,
            }
        );
    }
}