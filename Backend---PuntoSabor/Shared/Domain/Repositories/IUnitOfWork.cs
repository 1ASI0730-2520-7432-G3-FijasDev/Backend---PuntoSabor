namespace Backend___PuntoSabor.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();

}