namespace HotelListingAPI.Contracts;

// The T represents a class "where T : class"
// so that T would basically represent our data object
// Our generic repository here is going to be in charge of communicating with the database on our behalf.
// The controller knows that the generic repository is in charge of communicating with the database.
// The controller just wants to know that all work is getting done.

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int? id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task DeleteAsync(int id);

    Task UpdateAsync(T entity);

    Task<bool> Exists(int id);
}