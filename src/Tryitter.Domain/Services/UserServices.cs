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
      throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<User> GetAll()
    {
      throw new NotImplementedException();
    }

    public User? GetById(int id)
    {
      throw new NotImplementedException();
    }

    public User Update(int id, User entity)
    {
      throw new NotImplementedException();
    }
  }

}