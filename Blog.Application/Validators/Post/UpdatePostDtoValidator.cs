using Blog.Application.Validators.Extensions;
using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Post.Dto;
using FluentValidation;

namespace Blog.Application.Validators.Post;

public class UpdatePostDtoValidator : AbstractValidator<UpdatePostDto>
{
    public UpdatePostDtoValidator(
        IPostRepository postRepository)
    {
        RuleFor(dto => dto.PostId)
            .NotEmpty().WithMessage("Post id was not speciffied")
            .Must(postId => postId.IsValidGuid())
                .WithMessage("invalid post id");

        RuleFor(dto => dto.Content)
            .Length(10, 1000);
    }
}
