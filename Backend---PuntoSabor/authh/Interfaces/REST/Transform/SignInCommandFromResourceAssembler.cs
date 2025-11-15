using Backend___PuntoSabor.authh.Domain.Model.Commads;
using Backend___PuntoSabor.authh.Interfaces.REST.Resources;

namespace Backend___PuntoSabor.authh.Interfaces.REST.Transform;

public static class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource  resource)
    {
        return new SignInCommand(resource.Email/*, resource.Password*/);
    }
}