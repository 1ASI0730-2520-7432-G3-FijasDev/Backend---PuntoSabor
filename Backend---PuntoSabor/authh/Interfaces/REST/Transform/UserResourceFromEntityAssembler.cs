using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Interfaces.REST.Resources;

namespace Backend___PuntoSabor.authh.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(
            user.Id,
            user.Name,
            user.Email,
            //user.Password,
            user.CreatedAt
        );
    }
}