using ApiMarvel.Application.IRepositories;
using ApiMarvel.Application.IServices;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Infrastructure.Context;
using ApiMarvel.Infrastructure.Repositories;
using ApiMarvel.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiMarvel.Infrastructure.Extensions;

public static class InfrastructureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

      
        //Services
        services.AddScoped<IUnitOfWork>(provider => (IUnitOfWork)provider.GetRequiredService<AppDbContext>());
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddHttpContextAccessor();


        // repositories
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IComicRepository,ComicRepository >();
        services.AddScoped<IUserFavoriteComicRepository,UserFavoriteComicRepository>();

        return services;
    }
}
