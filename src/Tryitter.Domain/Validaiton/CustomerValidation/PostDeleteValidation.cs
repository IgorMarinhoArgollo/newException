﻿using FluentValidation;
using Tryitter.Domain.Models;

namespace Tryitter.Domain.Validation.CustomerValidation;

public class PostDeleteValidation : AbstractValidator<Post>
{
    public PostDeleteValidation()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id can not be null");
    }
}