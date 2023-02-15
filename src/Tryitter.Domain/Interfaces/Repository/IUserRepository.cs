using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IUserRepository
{
  Task<IEnumerable<User>> GetAll();
  Task<User> GetById(int id);
  Task<User> Create(User user);
  Task<User> Update(User user);
  Task Delete(User user);

}
