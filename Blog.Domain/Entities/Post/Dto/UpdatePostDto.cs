namespace Blog.Domain.Entities.Post.Dto;

public record UpdatePostDto
{
    public string PostId { get; set; } = "";
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}
