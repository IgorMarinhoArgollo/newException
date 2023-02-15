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

    public async Task<Post> Create(Post post)
    {
      _context.Posts.Add(post);
      await _context.SaveChangesAsync();
      return post;
    }

    public async Task Delete(Post post)
    {
      _context.Posts.Remove(post);
      await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Post>> GetAll()
    {
      return _context.Posts.ToList();
    }

    public async Task<Post> GetById(int id)
    {
      return _context.Posts.Where(post => post.Id == id).FirstOrDefault();
    }

    public async Task Update(Post post)
    {
      _context.Posts.Update(post);
      await _context.SaveChangesAsync();
    }
  }
}