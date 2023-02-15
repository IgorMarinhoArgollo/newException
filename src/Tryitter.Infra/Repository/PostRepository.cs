using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;
using Tryitter.Infra.Context;

namespace Tryitter.Infra.Repository
{
  public class PostRepository : EntityBaseRepository<Post>, IPostRepository
  {
    protected readonly TryitterContext _context;

    public PostRepository(TryitterContext context)
            : base(context)
    {
      _context = context;
    }

    public IEnumerable<Post> GetAllAsync()
    {
      return _context.Posts;
    }

    public Post GetPostByIdAsync(int id)
    {
      return _context.Posts.Where(post => post.Id == id).FirstOrDefault();
    }
    public void AddPost(Post post)
    {
      _context.Posts.Add(post);
      var user = _context.Users.Where(user => user == post.User).FirstOrDefault();
      user.Posts.Add(post);
      _context.SaveChanges();
    }
  }
}