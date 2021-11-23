using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Services
{
    public interface IPersonService
    {
        IEnumerable<PersonDTO> GetAllPersons();
        PersonDTO AddPerson(DateTime birthDate, string firstName, string lastName, string middleName);
        PersonDTO EditPerson(PersonDTO person);
        bool RemovePersonById(int personId);
        bool RemovePersonByFullName(string firstName, string lastName, string middleName);
        IEnumerable<LibraryCardWithoutPersonDTO> GetPersonBooks(int personId);
        LibraryCardDTO AddPersonBook(int personId, int bookId);
        void RemovePersonBook(int personId, int bookId);
    }
}
