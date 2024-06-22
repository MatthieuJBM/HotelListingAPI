using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data;

/*
 * TIP !!!
 * If you write "prop" and hit enter it will generate a property for you.
 */

public class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public double Rating { get; set; }

    /*
     * Hotel knows it is related to Country
     */

    [ForeignKey(nameof(CountryId))] public int CountryId { get; set; }

    public Country Country { get; set; }
}