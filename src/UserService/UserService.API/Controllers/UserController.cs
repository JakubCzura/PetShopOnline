using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserService.API.Controllers.Base;
using UserService.API.ExtensionMethods;
using UserService.Application.Commands.Users.CreateUser;
using UserService.Application.Commands.Users.DeleteUser;
using UserService.Application.Queries.Users.GetAll;
using UserService.Application.Queries.Users.GetById;
using UserService.Domain.Models.Entities;

namespace UserService.API.Controllers;

/// <summary>
/// Controller for user operations.
/// </summary>
/// <param name="mediator">Mediator for CQRS pattern.</param>
[ApiVersion(ApiVersioningInfo.Version_1_0)]
public class UserController(IMediator mediator) : ApiBaseController
{
    /// <summary>
    /// Returns all users from database.
    /// </summary>
    /// <returns>All users.</returns>
    [AllowAnonymous]
    [HttpGet("all")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
    public IActionResult GetUsers() => Ok(mediator.Send(new GetAllUsersQuery()));

    /// <summary>
    /// Returns a user by id.
    /// </summary>
    /// <param name="id">User's id.</param>
    /// <returns>User if found, otherwise null.</returns>
    [Authorize]
    [HttpGet("{id:int}")]
    [ProducesResponseType(200, Type = typeof(User))]
    public IActionResult GetUser([FromRoute] int id) => Ok(mediator.Send(new GetUserByIdQuery(id)));

    /// <summary>
    /// Adds a new user to the database.
    /// </summary>
    /// <param name="createUserCommand">Command to create a new user.</param>
    /// <returns>Newly created user.</returns>
    [Authorize(Roles = "User")]
    [HttpPost("add")]
    [ProducesResponseType(200, Type = typeof(User))]
    public IActionResult AddUser([FromBody] CreateUserCommand createUserCommand) => Ok(mediator.Send(createUserCommand));

    /// <summary>
    /// Deletes a user from the database by id.
    /// </summary>
    /// <param name="id">User's id.</param>
    /// <returns>Number of rows deleted from database.</returns>
    [Authorize(Roles = "User")]
    [HttpDelete("delete/{id:int}")]
    [ProducesResponseType(200, Type = typeof(int))]
    public IActionResult DeleteUser([FromRoute] int id) => Ok(mediator.Send(new DeleteUserCommand(id)));
}