using AutoMapper;
using BD3_University;
using DTO;

namespace DAL.Profiles
{
    public class ProfessorProfile : Profile
    {
        public ProfessorProfile()
        {
            CreateMap<Professor, ProfessprDTO>().ReverseMap();
        }
    }
}
