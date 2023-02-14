using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class PostInsertValidation : AbstractValidator<Post>
{
  public PostInsertValidation()
  {
    RuleFor(x => x.Title)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(x => x.Text)
        .NotNull()
        .WithMessage("Name can not be null");
  }
}
