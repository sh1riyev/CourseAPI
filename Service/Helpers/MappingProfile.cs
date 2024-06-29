using AutoMapper;
using Domain.Entity;
using Service.DTOs.Education;
using Service.DTOs.Group;
using Service.DTOs.Room;

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
            CreateMap<Room, RoomDto>();
            CreateMap<RoomCreateDto, Room>();
            CreateMap<RoomUpdateDto, Room>();

        }
    }
}
