using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IUserRepository : IEntityBaseRepository<User>
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetAddressByIdAsync(int id);
    Task<User> GetByNameAsync(string name);
}
