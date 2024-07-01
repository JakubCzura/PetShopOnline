using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Commands.Users.CreateSecretInfo;

/// <summary>
/// Command to create secret info about user and add it to database.
/// </summary>
/// <param name="SecretInfo">Secret info about user.</param>
public record CreateSecretInfoCommand(string SecretInfo) : IRequest<UserSecret>;