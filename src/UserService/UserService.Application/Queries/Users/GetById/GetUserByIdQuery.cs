using MediatR;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Queries.Users.GetById;

/// <summary>
/// Request to get a user by id.
/// </summary>
/// <param name="UserId">User's id.</param>
public record GetUserByIdQuery(int UserId) : IRequest<User?>;