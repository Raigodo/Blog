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
    public PostEntity(
        PostId id,
        string title,
        string content,
        UserId creatorId)
    {
        Id = id;
        Title = title;
        Content = content;
        CreatorId = creatorId;
        CreatedAt = DateTime.UtcNow;
        LastEditedAt = DateTime.UtcNow;
        Comments = new();
    }

    public PostId Id { get; private init; }
    public string Title { get; set; }
    public string Content { get; set; }
    public UserId CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastEditedAt { get; set; }
    public List<CommentEntity> Comments { get; private set; }
}
