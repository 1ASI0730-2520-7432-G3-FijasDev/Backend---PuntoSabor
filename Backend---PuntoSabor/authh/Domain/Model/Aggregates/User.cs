using Backend___PuntoSabor.authh.Domain.Model.Commads;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Backend___PuntoSabor.authh.Domain.Model.Aggregates;

public class User
{
    public int Id { get; } //id automatica +1
    public string Name { get; private set; } //name
    public string Email { get; private set; } //
    public DateTime CreatedAt { get; private set; } //

    protected User()
    {
        Name = string.Empty;
        Email = string.Empty;
        CreatedAt = DateTime.Now;
    }
    
    //constructor main
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
    
    //constructor del comando
    public User(CreateUserCommand command) 
        : this(command.Name, command.Email)
    {
    } 
}