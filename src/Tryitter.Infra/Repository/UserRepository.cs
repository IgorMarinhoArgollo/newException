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

    public async Task<User> Create(User user)
    {
      _context.Users.Add(user);
      await _context.SaveChangesAsync();
      return user;
    }

    public async Task Delete(User user)
    {
      _context.Users.Remove(user);
      await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetAll()
    {
      return _context.Users.ToList();
    }

    public async Task<User> GetById(int id)
    {
      return _context.Users.Where(user => user.Id == id).FirstOrDefault();
    }

    public async Task<User> Update(User user)
    {
      _context.Users.Update(user);
      await _context.SaveChangesAsync();
      return user;
    }
  }
}