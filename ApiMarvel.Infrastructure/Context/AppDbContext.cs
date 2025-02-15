using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Infrastructure.Context;

public class AppDbContext : IdentityDbContext<User>, IUnitOfWork
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public override DbSet<User> Users { get; set; }
    public  DbSet<Comic> Comics { get; set; }
    public  DbSet<UserFavoriteComic> UserFavoriteComics{ get; set; }        

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        builder.Ignore<IdentityRole>();
        builder.Ignore<IdentityUserRole<string>>();
        builder.Ignore<IdentityRoleClaim<string>>();
    }
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
