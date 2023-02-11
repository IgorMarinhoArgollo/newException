using Tryitter.Domain.Entities;
using Tryitter.Domain.Interfaces;

namespace Tryitter.Domain.Services
{
  public class PostServices : IServices<Post>
  {
    public Post Create(Post entity)
    {
      throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Post> GetAll()
    {
      throw new NotImplementedException();
    }

    public Post? GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Post Update(int id, Post entity)
    {
      throw new NotImplementedException();
    }
  }
}