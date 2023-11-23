using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.User.Vo;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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