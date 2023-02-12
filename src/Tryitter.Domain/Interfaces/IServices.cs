using System.Collections.Generic;

namespace Tryitter.Domain.Interfaces
{
  public interface IServices<T> where T : class
  {
    T? GetById(int id);
    IEnumerable<T> GetAll();
    T? Create(T entity);
    T? Update(int id, T entity);
    bool Delete(int id);
  }
}