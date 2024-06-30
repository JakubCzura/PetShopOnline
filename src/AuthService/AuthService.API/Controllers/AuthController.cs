using Asp.Versioning;
using AuthService.API.Controllers.Base;
using AuthService.API.ExtensionMethods;
using AuthService.Application.Commands.Users.SignUpCommand;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers;

/// <summary>
/// Controller to handle authentication.
/// </summary>
/// <param name="mediator">Tool to handle CQRS pattern.</param>
[ApiVersion(ApiVersioningInfo.Version_1_0)]
public class AuthController(IMediator mediator) : ApiBaseController
{
    /// <summary>
    /// Add new user to database.
    /// </summary>
    /// <param name="command">Command with user's details to add user to database.</param>
    /// <returns>Information about new user added.</returns>
    [AllowAnonymous]
    [HttpPost("signin")]
    public IActionResult SignUp([FromBody] SignInUserCommand command) => Ok(mediator.Send(command));

    /// <summary>
    /// Return secret info about user.
    /// </summary>
    /// <returns>Secret info about user.</returns>
    [Authorize]
    [HttpGet("secret")]
    public IActionResult GetSecretInfo() => Ok("This is a secret info");

    /// <summary>
    /// Create secret info about user and adds it to database.
    /// </summary>
    /// <returns>Secret that has been added to database.</returns>
    [Authorize(Roles = "User")]
    [HttpPost("secret")]
    public IActionResult CreateSecretInfo() => Ok("Secret info was written to database");
}