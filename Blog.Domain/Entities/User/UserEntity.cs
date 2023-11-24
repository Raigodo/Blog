using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.User.Vo;
using Microsoft.AspNetCore.Identity;

namespace Blog.Domain.Entities.User;

public sealed class UserEntity : IdentityUser<UserId>
{
    private UserEntity()
    {
        Id = new UserId(Guid.NewGuid());
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public string Nickname { get; set; } = $"User-{Guid.NewGuid().ToString().Substring(0, 8)}";


    private List<CommentEntity> _commentsCreated = new();
    private List<PostEntity> _postsCreated = new();
    public IReadOnlyList<CommentEntity> CreatedComments => _commentsCreated;
    public IReadOnlyList<PostEntity> CreatedPosts => _postsCreated;
}
