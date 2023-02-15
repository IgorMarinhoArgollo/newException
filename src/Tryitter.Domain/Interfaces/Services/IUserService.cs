using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Services
{
  public interface IUserService
  {
    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task<bool> Create(UserRequest user);
    Task<bool> Update(int id, UserRequest user);
    Task<bool> Delete(int id);
  }

}