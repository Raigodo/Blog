namespace Blog.Domain.Entities.Post.Dto;

public record CreatePostDto
{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}
