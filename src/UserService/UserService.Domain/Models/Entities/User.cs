namespace UserService.Domain.Models.Entities;

/// <summary>
/// Fake user entity to represent user in database.
/// </summary>
public class User
{
    /// <summary>
    /// User's id.
    /// </summary>
    public int Id { get; set; } = 1;

    /// <summary>
    /// User's name.
    /// </summary>
    public string Name { get; set; } = "John";

    /// <summary>
    /// User's email.
    /// </summary>
    public string Email { get; set; } = "Kowalski";

    /// <summary>
    /// User's password.
    /// </summary>
    public string Password { get; set; } = "WhateverItIsJustDemo123Hash123";
}