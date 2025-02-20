using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;

namespace ApiMarvel.Application.IRepositories;

public interface IComicRepository
{
    Task<IEnumerable<Comic>> GetAllAsync();
    Task<Comic?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(Comic comic , CancellationToken cancellationToken);
    void UpdateAsync(Comic comic , CancellationToken cancellationToken);
    Task DeleteAsync(Comic comic, CancellationToken cancellationToken);
    IQueryable<Comic> Queryable();
}
    
