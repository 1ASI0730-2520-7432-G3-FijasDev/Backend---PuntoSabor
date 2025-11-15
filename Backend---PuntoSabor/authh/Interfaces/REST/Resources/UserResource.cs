namespace Backend___PuntoSabor.authh.Interfaces.REST.Resources;

public record UserResource(
    int Id,
    string Name,
    string Email,
    //string Password,
    DateTime CreatedAt
);