namespace Backend___PuntoSabor.Shared.Domain.Repositories;

public interface IBaseRepository<TEntity>
{
    Task                        AddAsync(TEntity entity); // Add
    Task<TEntity?>              FindByIdAsync(int id); // Search
    void                        Update(TEntity entity); // Update
    void                        Remove(TEntity entity); // Remove
    Task<IEnumerable<TEntity>> ListAsync();
    
    Task<TEntity?>              FindByIdAsyncsString(string id); // Search

}