using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserService.API.Controllers.Base;
using UserService.API.ExtensionMethods;
using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.API.Controllers;

/// <summary>
/// Controller for user operations.
/// </summary>
/// <param name="userRepository">Fake user's database repository</param>
[ApiVersion(ApiVersioningInfo.Version_1_0)]
public class UserController(IUserRepository userRepository) : ApiBaseController
{
    [AllowAnonymous]
    [HttpGet("users")]
    public IActionResult GetUsers() => Ok(userRepository.GetUsers);

    [Authorize]
    [HttpGet("user")]
    public IActionResult GetUser() => Ok(userRepository.GetUser);

    [Authorize(Roles = "User")]
    [HttpPost("user")]
    public IActionResult AddUser([FromBody] User user) => Ok(userRepository.AddUser(user));

    [Authorize(Roles = "User")]
    [HttpDelete("delete")]
    public IActionResult DeleteUser([FromBody] User user) => Ok(userRepository.AddUser(user));
}