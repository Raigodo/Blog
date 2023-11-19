using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Dto;
using Blog.Domain.Entities.User.Vo;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        public PostController(IPostRepository postRepository)
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
