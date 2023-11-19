using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Post.Dto;

public record CreatePostDto
{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}
