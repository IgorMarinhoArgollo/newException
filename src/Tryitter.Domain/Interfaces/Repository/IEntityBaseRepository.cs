using System;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IEntityBaseRepository<T> : IDisposable where T : class
{
    void Add(T obj);
    void Update(T obj);
    void Remove(T obj);
}
