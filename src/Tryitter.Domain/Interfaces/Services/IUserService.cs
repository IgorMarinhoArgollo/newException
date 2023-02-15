using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Services
{
  public interface IUserService
  {
    Task<IEnumerable<UserResponse>> GetAll();
    Task<UserResponse> GetById(int id);
    Task<UserResponse> Create(UserRequest user);
    Task<UserResponse> Update(int id, UserRequest user);
    Task<bool> Delete(int id);
  }

}