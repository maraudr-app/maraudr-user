

namespace Maraudr.User.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<Domain.Entities.User> GetByIdAsync(Guid id)
        {
            return null;
        }

        public async Task<IEnumerable<Domain.Entities.User>> GetAllAsync()
        {
            return null;
        }

        public async Task<Domain.Entities.User> AddAsync(Domain.Entities.User user)
        {
            return null;
        }

        public async Task<Domain.Entities.User> UpdateAsync(Domain.Entities.User user)
        {
            return null;
        }

        public async Task DeleteAsync(Domain.Entities.User user)
        {
        }
    }
}
