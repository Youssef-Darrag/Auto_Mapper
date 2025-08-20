using Auto_Mapper.DTOs;
using Auto_Mapper.Models;
using AutoMapper;

namespace Auto_Mapper.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }
}
