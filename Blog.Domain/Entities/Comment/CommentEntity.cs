using Blog.Domain.Base;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Comment;

public sealed class CommentEntity : BaseEntity<CommentId>
{
    public CommentEntity() : base(new CommentId(Guid.Empty)) { }

    private CommentEntity(
        CommentId id,
        PostId postId,
        UserId creatorId,
        string content
        ) : base(id)
    {
        PostId = postId;
        CreatorId = creatorId;
        Content = content;
    }

    public UserId CreatorId { get; private set; } = new UserId(Guid.Empty);
    public PostId PostId { get; private set; } = new PostId(Guid.Empty);
    public string Content { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = default(DateTime);
    public DateTime LastEditedAt { get; private set; } = default(DateTime);

    //nullable to supress warnings about null to not-null conversion
    public UserEntity? Creator { get; set; }
    public PostEntity? Post { get; set; }

    public static CommentEntity Create(
        PostId postId,
        UserId creatorId,
        string content)
    {
        var comment = new CommentEntity(new CommentId(Guid.NewGuid()), postId, creatorId, content)
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
