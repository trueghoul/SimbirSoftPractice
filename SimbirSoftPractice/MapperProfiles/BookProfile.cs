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
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookWithoutLibraryCardsDTO, Book>();
            CreateMap<Book, BookWithoutLibraryCardsDTO>();
        }
    }
}
