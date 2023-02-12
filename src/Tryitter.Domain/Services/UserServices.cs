using Tryitter.Domain.Entities;
using Tryitter.Domain.Interfaces;


namespace Tryitter.Domain.Services
{
  public class UserServices : IServices<User>
  {
    private readonly IRepository<User> _repository;
    UserServices(IRepository<User> repository)
    {
      _repository = repository;
    }
    public User Create(User entity)
    {
      if (!string.IsNullOrEmpty(entity.Name) && !string.IsNullOrEmpty(entity.Password) && !string.IsNullOrEmpty(entity.Email))
      {
        User result = _repository.Create(entity);
        return result;
      }
      return null;
    }

    public bool Delete(int id)
    {
      if (GetById(id) != null)
      {
        _repository.Delete(id);
        return true;
      }
      return false;
    }

    public IEnumerable<User> GetAll()
    {
      return _repository.GetAll();
    }

    public User? GetById(int id)
    {
      return _repository.GetById(id);
    }

    public User Update(int id, User entity)
    {
      if (id < 0 && GetById(id) != null && !string.IsNullOrEmpty(entity.Name) && !string.IsNullOrEmpty(entity.Email) && !string.IsNullOrEmpty(entity.Password))
      {
        var result = _repository.Update(id, entity);
        return result;
      }
      return null;
    }
  }

}