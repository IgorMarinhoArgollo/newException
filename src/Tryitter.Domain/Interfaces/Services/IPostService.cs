using Tryitter.Domain.DTOs;

namespace Tryitter.Domain.Services
{
  public interface IPostService
  {
    Task<IEnumerable<PostResponse>> GetAll();
    Task<PostResponse> GetById(int id);
    Task<bool> Create(PostRequest post);
    Task<bool> Update(int id, PostRequest post);
    Task<bool> Delete(int id);
  }
  
}