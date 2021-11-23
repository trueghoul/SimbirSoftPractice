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
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<AuthorDTO, Author>();
            CreateMap<Author, AuthorDTO>();
        }
    }
}
