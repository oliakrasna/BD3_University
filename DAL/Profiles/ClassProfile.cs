using AutoMapper;
using BD3_University;
using DTO;

namespace DAL.Profiles
{
    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, ClassDTO>().ReverseMap();
        }
    }
}
