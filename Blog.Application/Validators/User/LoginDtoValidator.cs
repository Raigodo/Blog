using Blog.Domain.Entities.User.Dto;
using FluentValidation;

namespace Blog.Application.Validators.User;

public class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(dto => dto.Password)
            .Length(6, 16);

        RuleFor(dto => dto.Username)
            .Length(4, 16);
    }
}
