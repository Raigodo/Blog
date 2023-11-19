using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Comment.Dto;

public record UpdateCommentDto
{
    public string CommentId { get; set; } = "";
    public string PostId { get; set; } = "";
    public string Content { get; set; } = "";
}
