using Tryitter.Domain.Models;

namespace Tryitter.Domain.DTOs
{
  public class UserRequest
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Post>? Posts { get; set; }
  }
}