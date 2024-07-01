using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Queries.Users.GetAll;

/// <summary>
/// Query to get secret info about users.
/// </summary>
public record GetAllSecretInfosQuery() : IRequest<IEnumerable<UserSecret>>;