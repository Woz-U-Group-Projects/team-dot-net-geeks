using AutoMapper;
using PhotoScape.Dtos;
using PhotoScape.Entities;

namespace PhotoScape.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
