using AutoMapper;
using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository,
            IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public PersonDTO AddPerson(DateTime birthDate, string firstName, string lastName, string middleName)
        {
            var person = new Person
            {
                BirhDate = birthDate,
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName
            };
            _personRepository.Create(person);
            return _mapper.Map<PersonDTO>(person);
        }
        public PersonDTO EditPerson(PersonDTO personDTO)
        {
            var person = _personRepository.FindById(personDTO.Id);
            if (person != null)
            {
                person.LastName = personDTO.LastName;
                person.MiddleName = personDTO.MiddleName;
                person.FirstName = personDTO.FirstName;
                person.BirhDate = personDTO.BirhDate;
            }
            _personRepository.Update(person);
            return _mapper.Map<PersonDTO>(person);
        }

        public bool RemovePersonById(int personId)
        {
            var person = _personRepository.FindById(personId);
            if (person == null)
                return false;
            else
            {
                _personRepository.Remove(person);
                return true;
            }
        }
        public bool RemovePersonByFullName(string firstName, string lastName, string middleName)
        {
            var person = _personRepository.Get(p => p.FirstName == firstName && p.LastName == lastName && p.MiddleName == middleName).FirstOrDefault();
            if (person == null)
                return false;
            else
            {
                _personRepository.Remove(person);
                return true;
            }
        }
        public IEnumerable<PersonDTO> GetAllPersons()
        {
            return _personRepository.Get().Select(p => _mapper.Map<PersonDTO>(p));
        }

        public IEnumerable<LibraryCardWithoutPersonDTO> GetPersonBooks(int personId)
        {
            return _personRepository.GetLibraryCards(personId).Select(lc => _mapper.Map<LibraryCardWithoutPersonDTO>(lc));
        }
        public LibraryCardDTO AddPersonBook(int personId, int bookId)
        {
            return _mapper.Map<LibraryCardDTO>(_personRepository.AddLibraryCard(personId, bookId));
        }

        public void RemovePersonBook(int personId, int bookId)
        {
            _personRepository.RemoveLibraryCard(personId, bookId);
        }
    }
}
