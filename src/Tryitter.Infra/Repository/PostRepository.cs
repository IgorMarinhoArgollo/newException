using Tryitter.Domain.Models;
using Tryitter.Infra.Context;
using Tryitter.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Infra.Repository
{
  public class PostRepository : IPostRepository
  {
    private readonly TryitterContext _context;

    public PostRepository(TryitterContext context)
    {
      _context = context;
    }

    public Task<Post> Create(Post post)
    {
      throw new NotImplementedException();
    }

    public Task Delete(Post post)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetAll()
    {
      throw new NotImplementedException();
    }

    public Task<Post> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Task Update(Post post)
    {
      throw new NotImplementedException();
    }
  }
}