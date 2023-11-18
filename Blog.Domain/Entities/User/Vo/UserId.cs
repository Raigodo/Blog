using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.User.Vo;

public record UserId
{
    public UserId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private init; }
}
