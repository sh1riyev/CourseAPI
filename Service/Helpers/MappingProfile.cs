using AutoMapper;
using Domain.Entity;
using Service.DTOs.Group;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GroupCreateDto, Group>();
        }
    }
}
