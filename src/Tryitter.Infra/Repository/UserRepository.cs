using Tryitter.Domain.Models;
using Tryitter.Infra.Context;
using Tryitter.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Infra.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly TryitterContext _context;

    public UserRepository(TryitterContext context)
    {
      _context = context;
    }

    public Task<User> Create(User user)
    {
      throw new NotImplementedException();
    }

    public Task Delete(User user)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAll()
    {
      throw new NotImplementedException();
    }

    public Task<User> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Task Update(User user)
    {
      throw new NotImplementedException();
    }
  }
}