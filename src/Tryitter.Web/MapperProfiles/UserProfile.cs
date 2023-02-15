using AutoMapper;
using Tryitter.Domain.DTOs;
using Tryitter.Domain.Models;

namespace Tryitter.Profiles
{
  public class UserProfile : Profile
  {
    public UserProfile()
    {
      CreateMap<User, UserResponse>();
      CreateMap<UserRequest, User>();
    }
  }
}