using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Services
{
  public interface IPostService
  {
    Task<IEnumerable<Post>> GetAll();
    Task<Post> GetById(int id);
    Task<bool> Create(PostRequest post);
    Task<bool> Update(int id, PostRequest post);
    Task<bool> Delete(int id);
  }
  
}