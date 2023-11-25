using Blog.Domain.Entities.Comment.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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