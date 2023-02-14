using FluentValidation;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class UserDeleteValidation : AbstractValidator<User>
{
    public UserDeleteValidation()
    {
        RuleFor(user => user.Id)
            .NotNull()
            .WithMessage("Id can not be null");
    }
}
