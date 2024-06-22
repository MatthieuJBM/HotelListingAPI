namespace HotelListingAPI.Data;

public class Country
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string ShortName { get; set; }
    
    /*
     * 'virtual' keyword is used to indicate that a method or a property can be overriden
     * in a derived class. In the context of EF, marking a navigation property as virtual
     * allows EF to create a proxy around the property to enable lazy loading.
     */
    
    public virtual IList<Hotel> Hotels { get; set; }
    
}