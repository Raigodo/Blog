using Blog.Application.Validators.Extensions;
using Blog.Domain.Entities.User.Dto;
using FluentValidation;

namespace Blog.Application.Validators.User;

public class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(dto => dto.Password)
            .Length(6, 16)
            .Must(password => password.IsValidPassword())
                .WithMessage("provided password does not satisfy complexity requirements");

        RuleFor(dto => dto.Username)
            .Length(4, 16);

        RuleFor(dto => dto.Email)
            .EmailAddress();

        RuleFor(dto => dto.Nickname)
            .Length(4, 16);
    }
}
