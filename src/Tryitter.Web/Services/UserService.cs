using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;
using Tryitter.Infra.Repository;

namespace Tryitter.Domain.Services
{
  public class UserService : IUserService
  {
    private readonly UserRepository _repository;

    public UserService(UserRepository repository)
    {
      _repository = repository;
    }
    public async Task<bool> Create(UserRequest user)
    {
      User newUser = new() { Name = user.Name, Email = user.Email, Password = user.Password, Posts = user.Posts };
      await _repository.Create(newUser);
      return true;
    }

    public async Task<bool> Delete(int id)
    {
      var user = await _repository.GetById(id);
      if (user == null) return false;
      else return true;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
      return await _repository.GetAll();
    }

    public async Task<User> GetById(int id)
    {
      return await _repository.GetById(id);
    }

    public async Task<bool> Update(int id, UserRequest user)
    {
      var userFound = await _repository.GetById(id);
      if (userFound == null) return false;
      User newUser = new() { Id = userFound.Id, Name = user.Name, Email = user.Email, Password = user.Password, Posts = user.Posts };
      await _repository.Update(newUser);
      return true;
    }
  }


}