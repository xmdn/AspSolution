using AutoMapper;
using CustomClient.Application.Commands;
using CustomClient.Domain.Models;

namespace CustomClient.Infastructure.Mappers;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<CreateUserCommand, User>()
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Username))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));

    }
}