namespace Blog.Domain.Entities.Comment.Dto;

public record CreateCommentDto
{
    public string PostId { get; set; } = "";
    public string Content { get; set; } = "";
}
