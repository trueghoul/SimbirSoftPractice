using SimbirSoftPractice.DTOs;
using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person ToPersonMap(PersonDTO person);
        Person GetPerson(int id);
        void EditPerson(PersonDTO person);
        void DeletePerson(int id);
        void DeletePerson(string fullName);
    }
}
