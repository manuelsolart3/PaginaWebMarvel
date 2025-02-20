using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using ApiMarvel.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Repositories;

public class ComicRepository : IComicRepository
{
    private readonly AppDbContext _context;

    public ComicRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Comic>> GetAllAsync()
    {
        return await _context.Comics.ToListAsync();
    }

    public async Task<Comic> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Comics.FindAsync(id);
    }

    public async Task AddAsync(Comic comic, CancellationToken cancellationToken)
    {
        await _context.Comics.AddAsync(comic);
    }

    public void UpdateAsync(Comic comic, CancellationToken cancellationToken)
    {
        _context.Comics.Update(comic);
    }

    public async Task DeleteAsync(Comic comic, CancellationToken cancellationToken)
    {
        _context.Comics.Remove(comic);
    }

    public IQueryable<Comic> Queryable()
    {
       return _context.Comics.AsQueryable();
    }
}

