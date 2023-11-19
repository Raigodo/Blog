using Blog.Application.Validators.Extensions;
using Blog.Domain.Entities.Comment.Dto;
using FluentValidation;

namespace Blog.Application.Validators.Comment;

public class CreateCommentDtoValidator : AbstractValidator<CreateCommentDto>
{
    public CreateCommentDtoValidator()
    {
        RuleFor(dto => dto.PostId)
            .NotEmpty().WithMessage("Post id was not speciffied")
            .Must(postId => postId.IsValidGuid())
                .WithMessage("invalid post id");

        RuleFor(dto => dto.Content)
            .Length(10, 1000);
    }
}
