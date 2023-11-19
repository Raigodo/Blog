namespace Blog.Domain.Entities.User.Dto;

public record RegisterDto
{
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Email { get; set; } = "";
    public string Nickname { get; set; } = "";
}
