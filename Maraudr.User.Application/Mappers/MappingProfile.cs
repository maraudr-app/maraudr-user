using Maraudr.Application.DTOs;
using Maraudr.User.Application.DTOs.Requests;
using Maraudr.User.Application.DTOs.Responses;

namespace Maraudr.User.Application.Mappers;

using AutoMapper;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.User, UserDto>().ReverseMap();
            CreateMap<CreateUserDto, Domain.Entities.User>();
            CreateMap<UpdateUserDto, Domain.Entities.User>();
        }
    }

