using ApiMarvel.Domain.Models.Comics;

namespace ApiMarvel.Domain.Models.Users;

public class UserFavoriteComic
{
    public Guid Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public Guid ComicId { get; set; }
    public Comic Comic { get; set; }

    public UserFavoriteComic(Guid id, string userId,Guid comicId)
    {
        Id = id;
        UserId = userId;
        ComicId = comicId;
    }
}
