using AutoMapper;
using BookVaultAPI.DTOs;
using BookVaultAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookVaultAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Note, NoteDto>().ReverseMap();
            CreateMap<Share, ShareDto>().ReverseMap();
        }
    }
}
