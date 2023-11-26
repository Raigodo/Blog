using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Post.Dto;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("api/posts/")]
    public class PostsController : ControllerBase
    {
        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        private readonly IPostRepository _postRepository;


        [HttpGet("/test")]
        public IActionResult Foo(
            [FromServices] IValidator<CreatePostDto> postValidator)
        {
            return Ok("success");
        }
    }
}
