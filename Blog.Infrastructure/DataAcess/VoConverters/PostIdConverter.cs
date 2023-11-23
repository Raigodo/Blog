using Blog.Domain.Entities.Post.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Infrastructure.DataAcess.VoConverters;

internal class PostIdConverter : ValueConverter<PostId, Guid>
{
    public PostIdConverter(ConverterMappingHints? mappingHints = null)
        : base(
            id => id.Value,
            value => new PostId(value),
            mappingHints
        )
    { }

}
