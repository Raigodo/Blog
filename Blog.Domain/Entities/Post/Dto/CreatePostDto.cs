using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Post.Dto;

public record CreatePostDto
{
    required public string Title { get; set; }
    required public string Content { get; set; }
}
