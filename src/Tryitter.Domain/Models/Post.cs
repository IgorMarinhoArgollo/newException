namespace Tryitter.Domain.Models
{
  public class Post
  {
    public int? Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

  }
}