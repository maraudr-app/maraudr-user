

using Maraudr.Domain.Interfaces.Repositories;
using Maraudr.Domain.Entities;

namespace Maraudr.User.Infrastructure.Repositories
{
    public class UserRepository(UserContext context) : IUserRepository
    {
        private readonly UserContext _context = context;
        public async Task<Domain.Entities.User?> GetByIdAsync(Guid id)
        {
            return await _context.GetUserByIdAsync(id);
        }

        public async Task<IEnumerable<Domain.Entities.User?>> GetAllAsync()
        {
            return await _context.GetAllUsersAsync();
        }

        public async Task AddAsync(Domain.Entities.User user)
        {
            await _context.AddUserAsync(user) ;
        }
        
        public async Task DeleteAsync(Domain.Entities.User user)
        {
            await _context.DeleteUserAsync(user.Id);
        }
    }
}
