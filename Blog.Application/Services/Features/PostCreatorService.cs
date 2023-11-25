using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Dto;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Application.Services.Features;

public sealed class PostCreatorService
{
    public PostEntity CreatePost(UserId issuerId, CreatePostDto requestDto)
    {
        throw new NotImplementedException();
    }

    public PostEntity EditPost(UserId issuerId, UpdatePostDto requestDto)
    {
        throw new NotImplementedException();
    }

    public void DeletePost(UserId issuerId, PostId postId)
    {
        throw new NotImplementedException();
    }
}
