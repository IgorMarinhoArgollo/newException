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

    RuleFor(x => x.Id)
        .NotNull()
        .WithMessage("Id can not be null");

    RuleFor(x => x.Email)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(x => x.Name)
        .NotNull()
        .WithMessage("Nome can not be null");

    RuleFor(x => x.Password)
        .NotNull()
        .WithMessage("Password can not be null");

    RuleFor(x => x)
        .MustAsync(ValidationName)
        .WithMessage("Nome já cadastrado na base de dados");
  }

  private async Task<bool> ValidationName(User user, CancellationToken cancellationToken)
  {
    var userRepository = await _userRepository.GetByNameAsync(user.Name);

    return (userRepository?.Id) == user.Id;
  }
}
