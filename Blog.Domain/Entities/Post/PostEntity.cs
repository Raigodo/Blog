using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Post;

public sealed class PostEntity
{
    private PostEntity(
        PostId postId,
        string title,
        string content,
        UserId creatorId)
    {
        PostId = postId;
        Title = title;
        Content = content;
        CreatorId = creatorId;
    }

    public PostId PostId { get; private init; }
    public string Title { get; private set; }
    public string Content { get; private set; }
    public UserId CreatorId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastEditedAt { get; private set; }
    public List<CommentEntity> _comments { get; private set; } = new();
    public IReadOnlyList<CommentEntity> Comments { get => _comments; }

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
        var comment = CommentEntity.Create(PostId, commentator, content);
        _comments.Add(comment);
    }
}
