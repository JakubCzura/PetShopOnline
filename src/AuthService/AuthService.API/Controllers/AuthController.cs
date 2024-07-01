using Asp.Versioning;
using AuthService.API.Controllers.Base;
using AuthService.API.ExtensionMethods;
using AuthService.Application.Commands.Users.AuthorizeUser;
using AuthService.Application.Commands.Users.CreateSecretInfo;
using AuthService.Application.Queries.Users.GetAll;
using AuthService.Domain.Entities;
using AuthService.Domain.Responses;
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
    /// Authorize user and return jwt token.
    /// </summary>
    /// <param name="command">Command with user's details to add user to database.</param>
    /// <returns>Information about new user added.</returns>
    [AllowAnonymous]
    [HttpPost("authorize")]
    [ProducesResponseType(200, Type = typeof(AuthorizeUserResponse))]
    public IActionResult Authorize([FromBody] AuthorizeUserCommand command) => Ok(mediator.Send(command));

    /// <summary>
    /// Return secret info about user.
    /// </summary>
    /// <returns>Secret info about user.</returns>
    [Authorize]
    [HttpGet("secret")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<UserSecret>))]
    public IActionResult GetSecretInfo() => Ok(mediator.Send(new GetAllSecretInfosQuery()));

    /// <summary>
    /// Create secret info about user and adds it to database.
    /// </summary>
    /// <returns>Secret that has been added to database.</returns>
    [Authorize(Roles = "User")]
    [HttpPost("secret")]
    [ProducesResponseType(200, Type = typeof(UserSecret))]
    public IActionResult CreateSecretInfo([FromBody] CreateSecretInfoCommand createSecretInfoCommand)
        => Ok(mediator.Send(createSecretInfoCommand));
}