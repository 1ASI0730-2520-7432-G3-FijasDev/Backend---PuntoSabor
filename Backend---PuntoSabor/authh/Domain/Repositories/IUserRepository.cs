using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.Shared.Domain.Repositories;

namespace Backend___PuntoSabor.authh.Domain.Repositories;

public interface IUserRepository: IBaseRepository<User>
{
    // Method of Find User by Email
    Task<User?>  FindByEmail(string email);
    
    Task<bool> ExistsByIdAsync(int userId);
}