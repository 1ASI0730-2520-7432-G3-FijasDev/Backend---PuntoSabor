using Backend___PuntoSabor.authh.Application.Internal.OutboundServices;
using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Domain.Model.Commads;
using Backend___PuntoSabor.authh.Domain.Repositories;
using Backend___PuntoSabor.authh.Domain.Services;
using Backend___PuntoSabor.Shared.Domain.Repositories;

namespace Backend___PuntoSabor.authh.Application.Internal.CommandServices;

public class UserCommandService(
    IUserRepository userRepository,      // Repository for user data operations
    ITokenService  tokenService,         // Service for token generation
    //IHashingService hashingService,      // Service for password hashing
    IUnitOfWork unitOfWork) : IUserCommandService       // Unit of work for transaction management
{
    /// <summary>
    /// Handles the command to create a new user in the system
    /// </summary>
    /// <param name="command">Command containing user data to create</param>
    /// <returns>The created user or null if there was an error</returns>
    public async Task<User?> Handle(CreateUserCommand command)
    {
        // Generate hash for the provided password
        //var hashedPassword = hashingService.HashPassword(command.Password);
        
        // Create a new User instance with command data
        var user = new User(
            command.Name,        // Full name
            command.Email          // Email address
            //hashedPassword           // Hashed password
        );  
            
        // Add user to the repository
        await userRepository.AddAsync(user);
        
        // Commit changes to the database
        await unitOfWork.CompleteAsync();
        
        return user;
    }

    /// <summary>
    /// Handles user sign-in command
    /// </summary>
    /// <param name="command">Command containing login credentials</param>
    /// <returns>Tuple with authenticated user and generated token</returns>
    /// <exception cref="Exception">Thrown when credentials are invalid</exception>
    public async Task<(User user, string token)> Handle(SignInCommand command)
    {
        // Find user by email
        var user = await userRepository.FindByEmail(command.Email);
        
        // Verify if user exists and password is correct
        //if (user == null || !hashingService.VerifyPassword(command.Password, user.Password))
            throw new Exception("Invalid credentials");

        // Generate JWT token for authenticated user
        var token = tokenService.GenerateToken(user);
        
        // Return user and token
        return (user, token);
    }
}