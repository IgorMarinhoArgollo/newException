using Tryitter.Domain.Models;

namespace Tryitter.Domain.DTOs
{
  public class PostResponse
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string? Image { get; set; }
    public User User { get; set; }
  }
}