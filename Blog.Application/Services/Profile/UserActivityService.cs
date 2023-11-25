using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Application.Services.Profile;

public sealed class UserActivityService
{
    public IEnumerable<CommentEntity> GetUserComments(UserId issuerId, UserId userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PostEntity> GetuserPosts(UserId issuerId, UserId userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CommentEntity> GetPostsParticipated(UserId issuerId, UserId userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CommentEntity> GetSubscribedPosts(UserId issuerId, UserId userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CommentEntity> GetUnsubscribedPosts(UserId issuerId, UserId userId)
    {
        throw new NotImplementedException();
    }
}
