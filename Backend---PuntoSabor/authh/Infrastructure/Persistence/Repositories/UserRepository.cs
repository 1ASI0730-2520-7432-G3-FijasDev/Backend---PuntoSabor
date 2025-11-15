using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Backend___PuntoSabor.authh.Domain.Repositories;
using Backend___PuntoSabor.Shared.Infrastructure.Persistence.EFC.Configuration;
using Backend___PuntoSabor.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend___PuntoSabor.authh.Infrastructure.Persistence.Repositories;

public class UserRepository(AppDbContext context): BaseRepository<User>(context), IUserRepository
{
    public async Task<User?> FindByEmail(string email)
    {
        return await Context.Set<User>()
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<bool> ExistsByIdAsync(int userId)
    {
        return await Context.Set<User>()
            .AnyAsync(u => u.Id == userId);
    }
}