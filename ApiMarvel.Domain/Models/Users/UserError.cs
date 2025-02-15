using ApiMarvel.Domain.Abstractions;

namespace ApiMarvel.Domain.Models.Users;

public static class UserError
{
    public static readonly Error CreationFailed = new(
        "User.CreationFailed ",
        "Failed to create user");

    public static readonly Error UserNotFound = new(
        "User.UserNotFound ",
        "Failed to find the  user");

}
