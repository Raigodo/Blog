namespace Blog.Domain.Entities.Comment.Dto;

public record UpdateCommentDto
{
    public string CommentId { get; set; } = "";
    public string PostId { get; set; } = "";
    public string Content { get; set; } = "";
}
