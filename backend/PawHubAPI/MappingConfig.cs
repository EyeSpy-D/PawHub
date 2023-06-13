using AutoMapper;
using PawHubAPI.Models;
using PawHubAPI.Models.Dto;

namespace PawHubAPI;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<User, UserDTO>();
        CreateMap<UserDTO, User>();
        
        CreateMap<User, UserCreateDTO>();
        CreateMap<User, UserUpdateDTO>();
    }
}