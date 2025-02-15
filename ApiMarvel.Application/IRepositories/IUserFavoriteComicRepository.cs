using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Application.IRepositories;

public interface IUserFavoriteComicRepository
{
    IQueryable<UserFavoriteComic> Queryable();
    Task<List<UserFavoriteComic>> GetUserFavoriteComicsAsync(string userId);
}

