using Microsoft.AspNetCore.Identity;

namespace ApiMarvel.Domain.Models.Users;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public string Identification { get; set; }

    public User(string fullName, string identification, string email)
    {
        FullName = fullName;
        Identification = identification;
        Email = email;
    }

    public static User Create(
        string fullName,
        string identification,
        string email)
    {
        return new User(
            fullName,
            identification,
            email);
    }
}



