using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Comment.Dto;

public record CreateCommentDto
{
    required public string PostId { get; set; }
    required public string Content { get; set; }
}
