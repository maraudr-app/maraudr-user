using AutoMapper;
using Maraudr.Application.DTOs;
using Maraudr.User.Application.DTOs.Requests;
using Maraudr.User.Application.Exceptions;
using Maraudr.User.Infrastructure.Repositories;

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

    public async Task<UserDto> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        return _mapper.Map<UserDto>(user);
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
         return _mapper.Map<IEnumerable<UserDto>>(users);
    }


    public async Task<UserDto> CreateUserAsync(CreateUserDto createUserDto)
    {
        var userEntity = _mapper.Map<Domain.Entities.User>(createUserDto); 
        var user = await _userRepository.AddAsync(userEntity);
       
        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto> UpdateUserAsync(Guid userId, UpdateUserDto updateUserDto)
    {
        var user = await _userRepository.GetByIdAsync(userId);    
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }
        _mapper.Map(updateUserDto, user);
        var updatedUser = await _userRepository.UpdateAsync(user);
        return _mapper.Map<UserDto>(updatedUser);
    }

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