using System.ComponentModel.DataAnnotations;

namespace Tryitter.Domain.Models
{
  public class User
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(3, ErrorMessage = "Name must be greater than 3 characteres")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6, ErrorMessage = "Password must be greater than 6 characteres")]
    public string Password { get; set; }
    public ICollection<Post>? Posts {get; set;}    
  }
}