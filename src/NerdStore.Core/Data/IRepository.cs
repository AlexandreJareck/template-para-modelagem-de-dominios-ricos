using NerdStore.Core.DomainObject;

namespace NerdStore.Core.Data
{
    internal interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
    }
}