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
        public PostRepository(TryitterContext context)
            : base(context)
        {
        }

        public Task<IEnumerable<Post>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}