using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Domain.Model.Commads;

namespace Backend___PuntoSabor.authh.Domain.Services;

public interface IUserCommandService
{

    Task<User?> Handle(CreateUserCommand command);
    

    Task<(User user, string token)> Handle(SignInCommand command);

}