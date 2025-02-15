using ApiMarvel.Domain.Abstractions;

namespace ApiMarvel.Domain.Models.Comics;

public static class ComicError
{
    public static readonly Error DoesntExist = new(
        "Comic.DoesntExist ",
        "Comic Doesnt Exist");
}
