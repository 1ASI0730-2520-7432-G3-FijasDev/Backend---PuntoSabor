using Backend___PuntoSabor.authh.Domain.Model.Aggregates;

namespace Backend___PuntoSabor.authh.Application.Internal.OutboundServices;

public interface ITokenService
{
    string GenerateToken(User user);
    
    Task<int?> ValidateToken(string token);
    
}