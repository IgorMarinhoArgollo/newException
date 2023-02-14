using FluentValidation;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validaiton.CustomerValidation
{
  public class PostInsertValidation : AbstractValidator<Post>
  {
    public PostInsertValidation()
    {
      _ = RuleFor(post => post.Title)
          .NotNull()
          .WithMessage("Email can not be null");

      _ = RuleFor(post => post.Text)
          .NotNull()
          .WithMessage("Name can not be null");
    }
  }
}