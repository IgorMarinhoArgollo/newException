using AutoMapper;
using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;
using Tryitter.Infra.Repository;

namespace Tryitter.Domain.Services
{
  public class PostService : IPostService
  {
    private readonly PostRepository _repository;
    private readonly IMapper _mapper;
    public PostService(PostRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<bool> Create(PostRequest post)
    {
      Post newPost = new() {Title = post.Title, Text = post.Text, Image = post.Image };
      await _repository.Create(newPost);
      return true;
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

    public async Task<bool> Update(int id, PostRequest post)
    {
      var postFound = await _repository.GetById(id);
      if (postFound == null) return false;
      Post newPost = new() { Id = postFound.Id,  Title = post.Title, Text = post.Text, Image = post.Image };
      await _repository.Update(newPost);
      return true;
    }
  }
}