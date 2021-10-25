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
        IEnumerable<PersonWithoutLibraryCardsDTO> GetAllPersons();
        PersonWithoutLibraryCardsDTO AddPerson(DateTime birthDate, string firstName, string lastName, string middleName);
        PersonWithoutLibraryCardsDTO EditPerson(PersonWithoutLibraryCardsDTO person);
        bool RemovePersonById(int personId);
        bool RemovePersonByFullName(string firstName, string lastName, string middleName);
        IEnumerable<LibraryCardWithoutPersonDTO> GetPersonBooks(int personId);
        LibraryCardDTO AddPersonBook(int personId, int bookId);
        void RemovePersonBook(int personId, int bookId);
    }
}
