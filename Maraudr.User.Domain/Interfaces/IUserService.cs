
using Maraudr.Domain.Entities;
namespace Maraudr.Domain.Interfaces;
public interface IUserService
{
    Task<User> GetUserByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<Guid> CreateUserAsync(User createUserDto);
   /* Task<User> UpdateUserAsync(Guid id, User updateUserDto);*/
    Task DeleteUserAsync(Guid id);
}