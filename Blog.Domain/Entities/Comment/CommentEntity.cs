using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Comment;

public sealed class CommentEntity
{
    private CommentEntity(
        CommentId commentId,
        PostId postId,
        UserId userId,
        string content)
    {
        CommentId = commentId;
        PostId = postId;
        UserId = userId;
        Content = content;
    }

    public CommentId CommentId { get; private init; }
    public UserId UserId { get; private set; }
    public PostId PostId { get; private set; }
    public string Content { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastEditedAt { get; private set; }

    public static CommentEntity Create(
        PostId postId,
        UserId userId,
        string content)
    {
        var comment = new CommentEntity(new CommentId(Guid.NewGuid()), postId, userId, content)
        {
            CreatedAt = DateTime.UtcNow,
            LastEditedAt = DateTime.UtcNow,
        };
        return comment;
    }

    public void Edit(string editedContent)
    {
        Content = editedContent;
        LastEditedAt = DateTime.UtcNow;
    }
}
