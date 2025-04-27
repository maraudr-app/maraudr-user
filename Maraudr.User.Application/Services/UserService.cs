


using AutoMapper;
using Maraudr.Domain.Interfaces;
using Maraudr.Domain.Interfaces.Repositories;
using Maraudr.User.Application.DTOs.Requests;
using Maraudr.User.Application.DTOs.Responses;
using Maraudr.User.Application.Exceptions;

namespace Maraudr.User.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Domain.Entities.User> GetUserByIdAsync(Guid id)
    {
        return await _userRepository.GetByIdAsync(id);
        
    }

    public async Task<IEnumerable<Domain.Entities.User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync();
    }


    public async Task<Guid> CreateUserAsync(Domain.Entities.User user)
    {
        await _userRepository.AddAsync(user);
        return user.Id;


    }

   /* public async Task<UserDto> UpdateUserAsync(Guid userId, UpdateUserDto updateUserDto)
    {
        var user = await _userRepository.GetByIdAsync(userId);    
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }
        _mapper.Map(updateUserDto, user);
        var updatedUser = await _userRepository.UpdateAsync(user);
        return _mapper.Map<UserDto>(updatedUser);
    }*/

    public async Task DeleteUserAsync(Guid userId)
    { 
        var user = await _userRepository.GetByIdAsync(userId);    
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }

        await _userRepository.DeleteAsync(user);
    }
    

}