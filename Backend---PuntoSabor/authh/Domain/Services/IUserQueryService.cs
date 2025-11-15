using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Domain.Model.Queries;

namespace Backend___PuntoSabor.authh.Domain.Services;

public interface IUserQueryService
{
    
    Task<User?> Handle(GetUserByIDQuery query);
    
    Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
    
    
    Task<User?> Handle(GetUserByEmailQuery query);
}