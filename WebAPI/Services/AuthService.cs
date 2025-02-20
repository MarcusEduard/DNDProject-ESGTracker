using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace WebAPI.Services;
public class AuthService : IAuthService
{
    private readonly IList<User> users =
    [
        new()
        {
            Username = "9n10n2Guy",
            Email = "kasper@gmail.com",
            FullName = "Kasper Knop",
            Domain = "via.dk",
            Password = "password",
            Role = "Student",
            SecurityLevel = 2,
            Birthday = new DateTime(1988, 3, 14)
        },
        new()
        {
            Username = "Jasmin",
            Email = "316993@via.dk",
            FullName = "Jasmin Tazli",
            Domain = "admin.com",
            Password = "Fedeko",
            Role = "Teacher",
            SecurityLevel = 4,
            Birthday = new DateTime(1988, 3, 14)
        }
    ];

    public Task<User> ValidateUser(string username, string password)
    {
        User? existingUser = users.FirstOrDefault(u =>
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) ?? throw new Exception("User not found");

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return Task.FromResult(existingUser);
    }

    public Task RegisterUser(User user)
    {

        if (string.IsNullOrEmpty(user.Username))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(user.Password))
        {
            throw new ValidationException("Password cannot be null");
        }
        // Do more user info validation here

        // save to persistence instead of list

        users.Add(user);

        return Task.CompletedTask;
    }
}
