using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Comment.Vo;

public record CommentId
{
    public CommentId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private init; }
}
