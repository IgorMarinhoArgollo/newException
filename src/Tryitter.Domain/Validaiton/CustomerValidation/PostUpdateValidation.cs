using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class PostUpdateValidation : AbstractValidator<Post>
{
  public PostUpdateValidation()
  {
    RuleFor(post => post.Id)
        .NotNull()
        .WithMessage("Id can not be null");

    RuleFor(post => post.Title)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(post => post.Text)
        .NotNull()
        .WithMessage("Nome can not be null");
  }
}
