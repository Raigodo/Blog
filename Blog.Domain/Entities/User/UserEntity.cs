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
}
