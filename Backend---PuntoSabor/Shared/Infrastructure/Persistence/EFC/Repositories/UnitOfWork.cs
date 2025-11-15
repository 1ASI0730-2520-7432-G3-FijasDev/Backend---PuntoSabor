using Backend___PuntoSabor.Shared.Domain.Repositories;
using Backend___PuntoSabor.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace Backend___PuntoSabor.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    /// <inheritdoc />

    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}