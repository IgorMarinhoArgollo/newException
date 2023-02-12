using System.Collections.Generic;

namespace Tryitter.Domain.Interfaces
{
  public interface IRepository<T> where T: class
  {
    T GetById(int id);
    IEnumerable<T> GetAll();
    T Create(T entity);
    T Update(int id, T entity);
    void Delete(int id);
  }
}