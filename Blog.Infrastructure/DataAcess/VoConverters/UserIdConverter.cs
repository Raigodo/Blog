using Blog.Domain.Entities.User.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Infrastructure.DataAcess.VoConverters;

internal class UserIdConverter : ValueConverter<UserId, Guid>
{
    public UserIdConverter(ConverterMappingHints? mappingHints = null)
        : base(
            id => id.Value,
            value => new UserId(value),
            mappingHints
        )
    { }

}