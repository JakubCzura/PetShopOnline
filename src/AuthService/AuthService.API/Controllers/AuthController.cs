using Asp.Versioning;
using AuthService.API.Controllers.Base;
using AuthService.API.ExtensionMethods;
using AuthService.Application.Commands.Users.SignUpCommand;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers;

[ApiVersion(ApiVersioningInfo.Version_1_0)]
public class AuthController(IMediator mediator) : ApiBaseController
{
    [AllowAnonymous]
    [HttpPost("signin")]
    public IActionResult SignUp([FromBody] SignInUserCommand command) => Ok(mediator.Send(command));

    [Authorize]
    [HttpGet("secret")]
    public IActionResult GetSecretInfo() => Ok("This is a secret info");

    [Authorize(Roles = "User")]
    [HttpPost("secret")]
    public IActionResult CreateSecretInfo() => Ok("Secret info was written to database");
}