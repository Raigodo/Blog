using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Application.Services.Features;

public sealed class PostViewerService
{
    public IEnumerable<PostEntity> GetAllPost()
    {
        throw new NotImplementedException();
    }

    public PostEntity GetPost(PostId postId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CommentEntity> GetComments(PostId postId)
    {
        throw new NotImplementedException();
    }

    public void TogglePostNotiffications(
        UserId issuerId,
        UserId userId,
        PostId postId,
        bool getNotiffications)
    {
        throw new NotImplementedException();
    }
}
