using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.User.Dto;

public record RegisterDto
{
    required public string Username { get; set; }
    required public string Password { get; set; }
    required public string Email { get; set; }
    required public string Nickname { get; set; }
}
