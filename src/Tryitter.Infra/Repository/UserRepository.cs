using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;
using Tryitter.Infra.Context;

namespace Tryitter.Infra.Repository
{
  public class UserRepository : EntityBaseRepository<User>, IUserRepository
  {
    protected readonly TryitterContext _context;

    public UserRepository(TryitterContext context)
            : base(context)
    {
      _context = context;
    }

    public IEnumerable<User> GetAllAsync()
    {
      return _context.Users;
    }

    public User GetUserByIdAsync(int id)
    {
      return _context.Users.Where(user => user.Id == id).FirstOrDefault();
    }
  }
}