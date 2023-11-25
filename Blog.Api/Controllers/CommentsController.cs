using Blog.Application.Services.Features;
using Blog.Domain.Entities.Comment.Dto;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[Route("api/post/{PostId:guid}/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
    private readonly CommentingService _commentingService;
    private readonly PostViewerService _postViewverService;

    public CommentsController(
        CommentingService commentingService,
        PostViewerService postViewverService)
    {
        _commentingService = commentingService;
        _postViewverService = postViewverService;
    }

    [HttpGet("all")]
    public IActionResult GetComments(Guid postId)
    {
        var result = _postViewverService.GetComments(new PostId(postId));
        return Ok(result);
    }

    [HttpPost("create")]
    public IActionResult CreateComment([FromBody] CreateCommentDto requestDto)
    {
        var result = _commentingService.CreateComment(null, requestDto);
        return Ok(result);
    }

    [HttpPatch("edit/{CommentId:guid}")]
    public IActionResult EditComment(
        Guid PostId,
        Guid CommentId,
        [FromBody] UpdateCommentDto requestDto)
    {
        var result = _commentingService.UpdateComment(null, requestDto);
        return Ok(result);
    }

    [HttpDelete("remove/{CommentId:guid}")]
    public IActionResult DeleteComment(Guid postId, Guid commentId)
    {
        _commentingService.DeleteComment(null, new PostId(postId), new CommentId(commentId));
        return Ok();
    }
}
