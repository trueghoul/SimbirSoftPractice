using AutoMapper;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.MapperProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();
        }
    }
}
