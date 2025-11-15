namespace Backend___PuntoSabor.authh.Infrastructure.Hashing.ByCrypt.Services;

public class HashingService
{
    //Añadir contraseña al usuario
}

//example
/*
 * using BCryptNet = BCrypt.Net.BCrypt;

namespace backend_proyectonuestro.IAM.Infrastructure.Hashing.BCrypt.Services;

// This class implements the IHashingService interface to handle password hashing and verification.
public class HashingService : IHashingService
{
    // This method receives a plain text password and returns its hashed version using BCrypt.
    // BCrypt automatically generates a salt and applies a secure hashing algorithm.
    public string HashPassword(string password)
    {
        return BCryptNet.HashPassword(password);
    }

    // This method compares a plain text password with a previously hashed password.
    // It returns true if the password matches the hash, false otherwise.
    public bool VerifyPassword(string password, string passwordHash)
    {
        return BCryptNet.Verify(password, passwordHash);
    }
}
 */