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
    public UserEntity(
        UserId id,
        string nickname,
        string email)
    {
        Id = id;
        SecurityStamp = Guid.NewGuid().ToString();
        Nickname = nickname;
        Email = email;
    }

    public string Nickname { get; set; }
}
