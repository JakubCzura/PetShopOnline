namespace UserService.Domain.Models.Entities;

public class User
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "John";
    public string Email { get; set; } = "Kowalski";
    public string Password { get; set; } = "WhateverItIsJustDemo123Hash123";
}