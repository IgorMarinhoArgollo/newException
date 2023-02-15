using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class UserInsertValidation : AbstractValidator<User>
{
  private readonly IUserRepository _userRepository;

  public UserInsertValidation(IUserRepository customerRepository)
  {
    _userRepository = customerRepository;

    RuleFor(user => user.Email)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(user => user.Name)
        .NotNull()
        .WithMessage("Name can not be null");

    RuleFor(user => user.Password)
        .NotNull()
        .WithMessage("Name can not be null");

  }
}
