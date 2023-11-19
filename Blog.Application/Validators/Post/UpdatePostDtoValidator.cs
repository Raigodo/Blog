using Blog.Application.Validators.Extensions;
using Blog.Domain.Entities.Post.Dto;
using FluentValidation;

namespace Blog.Application.Validators.Post;

public class UpdatePostDtoValidator : AbstractValidator<UpdatePostDto>
{
    public UpdatePostDtoValidator()
    {
        RuleFor(dto => dto.PostId)
            .NotEmpty().WithMessage("Post id was not speciffied")
            .Must(postId => postId.IsValidGuid())
                .WithMessage("invalid post id");

        RuleFor(dto => dto.Content)
            .Length(10, 1000);
    }
}
