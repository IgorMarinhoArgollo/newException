using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IPostRepository
{
  Task<IEnumerable<Post>> GetAll();
  Task<Post> GetById(int id);
  Task<Post> Create(Post post);
   Task<Post> Update(Post post);
  Task Delete(Post post);

}
