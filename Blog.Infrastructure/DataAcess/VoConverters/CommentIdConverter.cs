using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.DataAcess.VoConverters;

internal class CommentIdConverter : ValueConverter<CommentId, Guid>
{
    public CommentIdConverter(ConverterMappingHints? mappingHints = null)
        : base(
            id => id.Value,
            value => new CommentId(value),
            mappingHints
        )
    { }

}