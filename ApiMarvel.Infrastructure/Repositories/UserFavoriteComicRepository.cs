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
}
