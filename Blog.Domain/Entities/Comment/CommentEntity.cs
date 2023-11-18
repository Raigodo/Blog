using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Comment;

public sealed class CommentEntity
{
    public CommentEntity(
        CommentId id,
        PostId postId,
        UserId userId,
        string content)
    {
        Id = id;
        PostId = postId;
        UserId = userId;
        Content = content;
        CreatedAt = DateTime.UtcNow;
        LastEditedAt = DateTime.UtcNow;
    }

    public CommentId Id { get; private init; }
    public UserId UserId { get; set; }
    public PostId PostId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastEditedAt { get; set; }
}
