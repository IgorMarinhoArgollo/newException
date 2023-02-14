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

    RuleFor(x => x.Email)
        .NotNull()
        .WithMessage("Email can not be null");

    RuleFor(x => x.Name)
        .NotNull()
        .WithMessage("Name can not be null");

    RuleFor(x => x.Password)
        .NotNull()
        .WithMessage("Name can not be null");

    RuleFor(x => x)
        .MustAsync(ValidationName)
        .WithMessage("Nome já cadastrado na base de dados");
  }

  private async Task<bool> ValidationName(User user, CancellationToken cancellationToken)
  {
    var userRepository = await _userRepository.GetByNameAsync(user.Name);

    return user.Name != userRepository?.Name;
  }
}
