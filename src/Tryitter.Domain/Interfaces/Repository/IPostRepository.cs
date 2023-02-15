using System.Collections.Generic;
using System.Threading.Tasks;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Interfaces.Repository;

public interface IPostRepository : IEntityBaseRepository<Post>
{
    Task<IEnumerable<Post>> GetAllAsync();
    Task<Post> GetPostByIdAsync(int id);
}
