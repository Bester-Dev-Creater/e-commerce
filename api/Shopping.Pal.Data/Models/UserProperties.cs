using System.ComponentModel.DataAnnotations;

namespace Shopping.Pal.Data.Models;

public class UserProperties
{
    [Key] public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}