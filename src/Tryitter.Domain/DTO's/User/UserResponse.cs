using Tryitter.Domain.Models;

namespace Tryitter.Domain.DTOs
{
  public class UserResponse
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Post>? Posts { get; set; }
  }
}