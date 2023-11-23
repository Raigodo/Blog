using Blog.Domain.Base;
using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Post;

public sealed class PostEntity : BaseEntity<PostId>
{
    public PostEntity() : base(new PostId(Guid.Empty)) { }

    private PostEntity(
        PostId id,
        string title,
        string content,
        UserId creatorId
        ) : base(id)
    {
        Title = title;
        Content = content;
        CreatorId = creatorId;
    }

    public string Title { get; private set; } = string.Empty;
    public string Content { get; private set; } = string.Empty;
    public UserId CreatorId { get; private set; } = new UserId(Guid.Empty);
    public DateTime CreatedAt { get; private set; } = default(DateTime);
    public DateTime LastEditedAt { get; private set; } = default(DateTime);

    public List<CommentEntity> _comments { get; private set; } = new();
    public IReadOnlyList<CommentEntity> Comments => _comments;
    public UserEntity Creator { get; set; }

    public static PostEntity Create(
        string title,
        string content,
        UserId creatorId)
    {
        var post = new PostEntity(
            new PostId(Guid.NewGuid()),
            title,
            content,
            creatorId)
        {
            CreatedAt = DateTime.UtcNow,
            LastEditedAt = DateTime.UtcNow,
        };
        return post;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
        LastEditedAt = DateTime.UtcNow;
    }

    public void Edit(string editedContent)
    {
        Content = editedContent;
        LastEditedAt = DateTime.UtcNow;
    }

    public void AddComment(UserId commentator, string content)
    {
        var comment = CommentEntity.Create(Id, commentator, content);
        _comments.Add(comment);
    }
}
