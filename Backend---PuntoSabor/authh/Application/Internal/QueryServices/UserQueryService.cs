using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Domain.Model.Queries;
using Backend___PuntoSabor.authh.Domain.Repositories;
using Backend___PuntoSabor.authh.Domain.Services;

namespace Backend___PuntoSabor.authh.Application.Internal.QueryServices;

public class UserQueryService(IUserRepository userRepository) : IUserQueryService
{
    public async Task<User?> Handle(GetUserByIDQuery query)
    {
        return await userRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }

    public async Task<User?> Handle(GetUserByEmailQuery query)
    {
        return await userRepository.FindByEmail(query.Email);
    }
}