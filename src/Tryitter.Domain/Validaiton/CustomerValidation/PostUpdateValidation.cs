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
    RuleFor(x => x.Id)
        .NotNull()
        .WithMessage("Id can not be null");

    RuleFor(x => x.Title)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(x => x.Text)
        .NotNull()
        .WithMessage("Nome can not be null");
  }
}
