using Blog.Domain.Entities.User.Vo;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.User;

public class UserEntity : IdentityUser<UserId>
{
    private UserEntity()
    {
        Id = new UserId(Guid.NewGuid());
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public string Nickname { get; set; } = $"User-{ Guid.NewGuid().ToString().Substring(0, 8) }";
}
