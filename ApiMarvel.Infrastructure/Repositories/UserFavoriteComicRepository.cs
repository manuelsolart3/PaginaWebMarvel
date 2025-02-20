using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using ApiMarvel.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Repositories;

public class UserFavoriteComicRepository : IUserFavoriteComicRepository
{
    private readonly AppDbContext _context;

    public UserFavoriteComicRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<UserFavoriteComic> Queryable()
    {
        return _context.UserFavoriteComics.AsQueryable();
    }
    public async Task<List<UserFavoriteComic>> GetUserFavoriteComicsAsync(string userId)
    {
        return await _context.UserFavoriteComics
            .Where(ufc => ufc.UserId == userId)
            .Include(ufc => ufc.Comic)
            .ToListAsync();
    }
    public async Task AddAsync(UserFavoriteComic userFavoriteComic, CancellationToken cancellationToken)
    {
        await _context.UserFavoriteComics.AddAsync(userFavoriteComic);
    }
    public async Task<bool> ExistsAsync(string userId, Guid comicId, CancellationToken cancellationToken)
    {
        return await _context.Set<UserFavoriteComic>()
            .AnyAsync(ufc => ufc.UserId == userId && ufc.ComicId == comicId, cancellationToken);
    }
    public async Task<UserFavoriteComic?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.UserFavoriteComics
            .FirstOrDefaultAsync(ufc => ufc.Id == id, cancellationToken);
    }
    public async Task DeleteAsync(UserFavoriteComic entity, CancellationToken cancellationToken)
    {
        _context.UserFavoriteComics.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }


}
