using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Interfaces.REST.Resources;

namespace Backend___PuntoSabor.authh.Interfaces.REST.Transform;

public class AuthenticatedUserResourceFromEntityAssembler
{
    public static AuthenticatedUserResource ToResourceFromEntity(User user, string token)
    {
        return new AuthenticatedUserResource(user.Id, user.Email, token);
    }
}