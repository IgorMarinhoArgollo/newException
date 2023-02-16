using AutoMapper;
using Tryitter.Domain.DTOs;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;
using Tryitter.Domain.Services;

namespace Tryitter.Web.Services
{
  public class UserService : IUserService
  {
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }
    public async Task<UserResponse> Create(UserRequest user)
    {
     var result = await _repository.Create(_mapper.Map<User>(user));
      return _mapper.Map<UserResponse>(result);
    }

    public async Task<bool> Delete(int id)
    {
      var user = await _repository.GetById(id);
      if (user == null) return false;
      else return true;
    }

    public async Task<IEnumerable<UserResponse>> GetAll()
    {
      var users = await _repository.GetAll();
      return users.Select(user => _mapper.Map<UserResponse>(user));
    }

    public async Task<UserResponse> GetById(int id)
    {
      var user = await _repository.GetById(id);
      return _mapper.Map<UserResponse>(user);
    }

    public async Task<UserResponse> Update(int id, UserRequest user)
    {
      var userFound = await _repository.GetById(id);
      if (userFound == null) return null;
      var result = await _repository.Update(_mapper.Map<User>(user));
      return _mapper.Map<UserResponse>(result);
    }
  }
}