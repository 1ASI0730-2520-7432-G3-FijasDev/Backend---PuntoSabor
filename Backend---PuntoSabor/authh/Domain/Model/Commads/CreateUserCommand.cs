namespace Backend___PuntoSabor.authh.Domain.Model.Commads;

public record CreateUserCommand(
    string Name,
    string Email
);