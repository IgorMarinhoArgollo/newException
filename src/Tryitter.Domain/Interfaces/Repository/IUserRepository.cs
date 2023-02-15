using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IUserRepository
{
  IEnumerable<User> GetAllAsync();
  User GetUserByIdAsync(int id);

}
