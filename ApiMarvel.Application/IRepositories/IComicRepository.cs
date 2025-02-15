using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Application.IRepositories;

public interface IComicRepository
{
    Task<IEnumerable<Comic>> GetAllAsync();
    Task<Comic?> GetByIdAsync(Guid id);
    Task AddAsync(Comic comic);
    void UpdateAsync(Comic comic);
    void Delete(Guid id);
    IQueryable<Comic> Queryable();
}
    
