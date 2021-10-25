using AutoMapper;
using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.MapperProfiles
{
    public class LibraryCardProfile : Profile
    {
        public LibraryCardProfile()
        {
            CreateMap<LibraryCardWithoutPersonDTO, LibraryCard>();
            CreateMap<LibraryCard, LibraryCardWithoutPersonDTO>();

            CreateMap<LibraryCardDTO, LibraryCard>();
            CreateMap<LibraryCard, LibraryCardDTO>();
        }
    }
}
