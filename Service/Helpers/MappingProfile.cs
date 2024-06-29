using AutoMapper;
using Domain.Entity;
using Service.DTOs.Education;
using Service.DTOs.Group;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GroupCreateDto, Group>();
            CreateMap<EducationCreateDto, Education>();
            CreateMap<EducationUpdateDto, Education>();
            CreateMap<Education, EducationDto>();

        }
    }
}
