using Blog.Application.Services.Profile;
using Blog.Application.Services.Security;
using Blog.Domain.Entities.User.Vo;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[Route("api/profile/{userId:guid}/edit")]
[ApiController]
public class EditProfileController : ControllerBase
{
    private readonly ProfileCustomizationService _customizeService;
    private readonly AccountRecoveryService _recoveryService;

    public EditProfileController(
        ProfileCustomizationService customizeService,
        AccountRecoveryService recoveryService)
    {
        _customizeService = customizeService;
        _recoveryService = recoveryService;
    }

    [HttpPatch("nickname")]
    public IActionResult ChangeNickname(
        Guid userId,
        [FromBody] string nickname)
    {
        _customizeService.ChangeNickname(null, new UserId(userId), nickname);
        return Ok("Success");
    }

    [HttpPatch("username")]
    public IActionResult ChangeUsername(
        Guid userId,
        [FromBody] string username)
    {
        _recoveryService.ChangeUsername(null, new UserId(userId), username);
        return Ok("Success");
    }

    [HttpPatch("password")]
    public IActionResult ChangePassword(
        Guid userId,
        [FromBody] string password)
    {
        _recoveryService.ChangePassword(null, new UserId(userId), password);
        return Ok("Success");
    }

    [HttpPatch("email")]
    public IActionResult ChangeEmail(
        Guid userId,
        [FromBody] string email)
    {
        _recoveryService.ChangeEmail(null, new UserId(userId), email);
        return Ok("Success");
    }
}
