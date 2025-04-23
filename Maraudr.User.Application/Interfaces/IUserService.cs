using Maraudr.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maraudr.User.Application.DTOs.Requests;

namespace Maraudr.User.Application;

public interface IUserService
{
    Task<UserDto> GetUserByIdAsync(Guid id);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task<UserDto> CreateUserAsync(CreateUserDto createUserDto);
    Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUserDto);
    Task DeleteUserAsync(Guid id);
}