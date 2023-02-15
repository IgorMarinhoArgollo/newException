using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IPostRepository : IEntityBaseRepository<Post>
{
  IEnumerable<Post> GetAllAsync();
  Post GetPostByIdAsync(int id);
  void AddPost(Post post);

}
