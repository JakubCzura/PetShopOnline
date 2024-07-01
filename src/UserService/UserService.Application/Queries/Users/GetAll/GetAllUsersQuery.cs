using MediatR;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Queries.Users.GetAll;

/// <summary>
/// Query for getting all users from database.
/// </summary>
public record GetAllUsersQuery() : IRequest<IEnumerable<User>>;