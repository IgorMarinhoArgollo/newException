using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Tryitter.Domain.Interfaces.Repository;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class UserUpdateValidation : AbstractValidator<User>
{
  private readonly IUserRepository _userRepository;

  public UserUpdateValidation(IUserRepository userRepository)
  {
    _userRepository = userRepository;

    RuleFor(user => user.Id)
        .NotNull()
        .WithMessage("Id can not be null");

    RuleFor(user => user.Email)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(user => user.Name)
        .NotNull()
        .WithMessage("Nome can not be null");

    RuleFor(user => user.Password)
        .NotNull()
        .WithMessage("Password can not be null");

    RuleFor(user => user)
        .MustAsync(ValidationName)
        .WithMessage("User already registered");
  }

  private async Task<bool> ValidationName(User user, CancellationToken cancellationToken)
  {
    var userRepository = await _userRepository.GetByNameAsync(user.Name);

    return (userRepository?.Id) == user.Id;
  }
}
