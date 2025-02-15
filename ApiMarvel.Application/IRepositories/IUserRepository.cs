using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Application.IRepositories;

public interface IUserRepository
{
    IQueryable<User> Queryable();
}
