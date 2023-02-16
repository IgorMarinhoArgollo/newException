using AutoMapper;
using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;
using Tryitter.Domain.Services;
using Tryitter.Domain.Interfaces.Repository;

namespace Tryitter.Web.Services
{
  public class PostService : IPostService
  {
    private readonly IPostRepository _repository;
    private readonly IMapper _mapper;
    public PostService(IPostRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<PostResponse> Create(PostRequest post)
    {
      var result = await _repository.Create(_mapper.Map<Post>(post));
      return _mapper.Map<PostResponse>(result);
    }

    public async Task<bool> Delete(int id)
    {
      var post = await _repository.GetById(id);
      if (post == null) return false;
      else return true;
    }

    public async Task<IEnumerable<PostResponse>> GetAll()
    {
      var posts = await _repository.GetAll();
      return posts.Select(post => _mapper.Map<PostResponse>(post));
    }

    public async Task<PostResponse> GetById(int id)
    {
      var post = await _repository.GetById(id);
      return _mapper.Map<PostResponse>(post);
    }

    public async Task<PostResponse> Update(int id, PostRequest post)
    {
      var postFound = await _repository.GetById(id);
      if (postFound == null) return null;
     var result = await _repository.Update(_mapper.Map<Post>(post));
      return _mapper.Map<PostResponse>(result);
    }
  }
}