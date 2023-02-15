using System.ComponentModel.DataAnnotations;

namespace Tryitter.Domain.Models
{
  public class Post
  {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MinLength(6, ErrorMessage = "Title must be greater than 6 characteres")]

    public string Title { get; set; }

    [Required]
    [MinLength(6, ErrorMessage = "Text must be greater than 6 characteres")]

    public string Text { get; set; }
    public string? Image { get; set; }


    public User User {get; set;}

  }
}