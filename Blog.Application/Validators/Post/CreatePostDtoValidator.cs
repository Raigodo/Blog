using Blog.Domain.Entities.Post.Dto;
using FluentValidation;

namespace Blog.Application.Validators.Post;

public class CreatePostDtoValidator : AbstractValidator<CreatePostDto>
{
    public CreatePostDtoValidator()
    {
        RuleFor(dto => dto.Title)
            .Length(4, 32);

        RuleFor(dto => dto.Content)
            .Length(4, 1000);
    }
}
