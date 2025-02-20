using ApiMarvel.Domain.Abstractions;

namespace ApiMarvel.Domain.Models.Comics;

public static class ComicError
{
    public static readonly Error DoesntExist = new(
        "Comic.DoesntExist ",
        "Comic Doesnt Exist");

    public static readonly Error alreadyIsYourFavorite = new(
     "Comic.alreadyIsYourFavorite",
     "The Comic already is in your favorites");
}
