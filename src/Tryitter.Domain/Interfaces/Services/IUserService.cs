using Tryitter.Domain.DTOs;

namespace Tryitter.Domain.Services
{
  public interface IUserService
  {
    Task<IEnumerable<UserResponse>> GetAll();
    Task<UserResponse> GetById(int id);
    Task<bool> Create(UserRequest user);
    Task<bool> Update(int id, UserRequest user);
    Task<bool> Delete(int id);
  }

}