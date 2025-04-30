using AutoMapper;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace ElsiumC.Infrastructure.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<UserDtoForCreation, IdentityCitizen>();
            CreateMap<IdentityCitizen, UserDtoForUpdate>();
            CreateMap<UserDtoForUpdate, IdentityCitizen>();
            CreateMap<IdentityCitizen,UserDtoForProfileList>();
            CreateMap<IdentityCitizen,UserDtoForList>();
        }
    }
}