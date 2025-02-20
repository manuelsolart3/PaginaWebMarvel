using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Application.IRepositories;

public interface IUserFavoriteComicRepository
{
    IQueryable<UserFavoriteComic> Queryable();
    Task<List<UserFavoriteComic>> GetUserFavoriteComicsAsync(string userId);
    Task AddAsync(UserFavoriteComic userFavoriteComic, CancellationToken cancellationToken);
    Task<bool> ExistsAsync(string userId, Guid comicId, CancellationToken cancellationToken);
    Task<UserFavoriteComic?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task DeleteAsync(UserFavoriteComic entity, CancellationToken cancellationToken);

}

