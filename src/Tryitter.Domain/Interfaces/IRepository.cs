using System.Collections.Generic;

namespace Tryitter.Domain.Interface
{
  public interface IRepository<T> where T: class
  {
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Create(T entity);
    T Update(int id, T entity);
    void Delete(int id);
  }
}