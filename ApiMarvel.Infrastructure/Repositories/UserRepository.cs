using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Models.Users;
using ApiMarvel.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<User> Queryable()
    {
        return _context.Users.AsQueryable();
    }
}
