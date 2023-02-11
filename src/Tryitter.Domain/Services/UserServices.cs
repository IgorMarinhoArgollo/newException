using Tryitter.Domain.Entities;
using Tryitter.Domain.Interfaces;


namespace Tryitter.Domain.Services
{
  public class UserServices : IServices<User>
  {
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