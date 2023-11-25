using Blog.Application.Services.Account;
using Blog.Domain.Entities.User.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly AuthenticationService _authService;

    public AuthenticationController(
        AuthenticationService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto requestDto)
    {
        _authService.Login(requestDto);
        return Ok("Success");
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto requestDto)
    {
        var result = _authService.Register(requestDto);
        return Ok(result);
    }
}
