using Microsoft.EntityFrameworkCore;
using SimbirSoftPractice.DTOs;
using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository 
    {
        public PersonRepository(LibraryDBContext context)
            :base(context)
        {

        }
        public LibraryDBContext LibraryDBContext
        {
            get { return Context as LibraryDBContext; }
        }

        public void DeletePerson(int id)
        {
            LibraryDBContext.People.Remove(GetPerson(id));
        }

        public void DeletePerson(string fullName)
        {
            LibraryDBContext.People.RemoveRange(GetPerson(fullName));
        }

        public void EditPerson(PersonDTO person)
        {
            LibraryDBContext.People.Remove(LibraryDBContext.People.Where(p => p.Id == person.Id).FirstOrDefault());
            LibraryDBContext.People.Add(ToPersonMap(person));
        }

        public Person GetPerson(int id)
        {
            return LibraryDBContext.People.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Person> GetPerson(string fullName)
        {
            return LibraryDBContext.People.Where(p => (p.FirstName + ' ' + p.LastName + ' ' + p.MiddleName).Contains(fullName));
        }

        public Person ToPersonMap(PersonDTO person)
        {
            return new Person
            {
                Id = person.Id,
                BirhDate = person.BirhDate,
                FirstName = person.FirstName,
                LastName = person.LastName,
                MiddleName = person.MiddleName
            };
        }
    }
}
