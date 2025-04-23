namespace Maraudr.User.Infrastructure.Repositories;

public interface IUserRepository
{
    Task<Domain.Entities.User> GetByIdAsync(Guid id);
    Task<IEnumerable<Domain.Entities.User>> GetAllAsync();
    Task<Domain.Entities.User> AddAsync(Domain.Entities.User user);
    Task<Domain.Entities.User> UpdateAsync(Domain.Entities.User user);
    Task DeleteAsync(Domain.Entities.User user);
}