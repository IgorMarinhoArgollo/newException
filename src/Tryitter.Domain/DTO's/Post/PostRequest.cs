using Tryitter.Domain.Models;

namespace Tryitter.Domain.DTOs
{
  public class PostRequest
  {
    public string Title { get; set; }
    public string Text { get; set; }
    public string? Image { get; set; }
    public int UserId { get; set; }
    public User? user { get; set; }
  }
}