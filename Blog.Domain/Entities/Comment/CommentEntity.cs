﻿using Blog.Domain.Base;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Comment;

public sealed class CommentEntity : BaseEntity<CommentId>
{
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

    public UserId CreatorId { get; private set; }
    public PostId PostId { get; private set; }
    public string Content { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastEditedAt { get; private set; }

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
