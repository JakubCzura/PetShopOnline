namespace AuthService.Domain.Entities;

/// <summary>
/// Entity that represents secret info about user.
/// </summary>
public class UserSecret
{
    /// <summary>
    /// Id of the secret info
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Something secret about user.
    /// </summary>
    public string SecretInfo { get; set; } = string.Empty;
}