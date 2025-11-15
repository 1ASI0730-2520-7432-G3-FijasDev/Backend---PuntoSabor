using Backend___PuntoSabor.authh.Domain.Model.Commads;
using Backend___PuntoSabor.authh.Interfaces.REST.Resources;

namespace Backend___PuntoSabor.authh.Interfaces.REST.Transform;

public static class CreateUserCommandFromResourceAssembler
{
    public static CreateUserCommand ToCommandFromResource(CreateUserResource resource)
    {
        return new CreateUserCommand(
            resource.Name,
            resource.Email
            //resource.Password
        );
    }
}