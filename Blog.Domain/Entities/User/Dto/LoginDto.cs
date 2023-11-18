using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.User.Dto;

public class LoginDto
{
    required public string Username { get; set; }
    required public string Password { get; set; }
}
