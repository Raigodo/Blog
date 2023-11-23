using Blog.Domain.Entities.Post.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.DataAcess.VoConverters;

internal class PostIdConverter : ValueConverter<PostId, Guid>
{
    public PostIdConverter(ConverterMappingHints? mappingHints = null) 
        : base(
            id => id.Value,
            value => new PostId(value),
            mappingHints
        ) { }

}
