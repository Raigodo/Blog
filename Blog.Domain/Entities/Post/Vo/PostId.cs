using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Post.Vo;

public record PostId
{
    public PostId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private init; }
}
