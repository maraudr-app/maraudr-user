using Maraudr.Domain.Entities;

namespace Maraudr.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task<IEnumerable<User?>> GetAllAsync();
    Task AddAsync(User user);
    //Task<User?> UpdateAsync(User user);
    Task DeleteAsync(User user);
}