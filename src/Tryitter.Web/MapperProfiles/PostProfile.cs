using AutoMapper;
using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;

namespace Tryitter.Profiles
{
  public class PostProfile : Profile
  {
    public PostProfile()
    {
      CreateMap<Post, PostResponse>();
      CreateMap<PostRequest, Post>();
    }
  }
}