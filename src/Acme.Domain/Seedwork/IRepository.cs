using Acme.Domain.Seedwork;

namespace Acme.Domain.Seedwork;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}
