using Tryitter.Domain.Entities;
using Tryitter.Domain.Interfaces;
using System;

namespace Tryitter.Domain.Services
{
  public class PostServices : IServices<Post>
  {
    private readonly IRepository<Post> _repository;
    PostServices(IRepository<Post> repository)
    {
      _repository = repository;
    }
    public Post Create(Post entity)
    {
      if(!string.IsNullOrEmpty(entity.Title) && !string.IsNullOrEmpty(entity.Text)) {
        Post result = _repository.Create(entity);
        return result;
      }
      return null;
    }

    public bool Delete(int id)
    {
      if(GetById(id) != null) {
        _repository.Delete(id);
        return true;
      }
      return false;
    }

    public IEnumerable<Post> GetAll()
    {
      return _repository.GetAll();
    }

    public Post? GetById(int id)
    {
      return _repository.GetById(id);
    }

    public Post Update(int id, Post entity)
    {
      if (GetById(id) != null && !string.IsNullOrEmpty(entity.Title) && !string.IsNullOrEmpty(entity.Text))
      {
        var result = _repository.Update(id, entity);
        return result;
      }
      return null;
    }
  }
}