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
        private readonly IBookRepository _bookRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly LibraryDBContext _context;
        public PersonService(IPersonRepository personRepository,
            IMapper mapper,
            IBookRepository bookRepository,
            IGenreRepository genreRepository,
            IAuthorRepository authorRepository,
            LibraryDBContext context)
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
            _genreRepository = genreRepository;
            _context = context;
        }

        public PersonWithoutLibraryCardsDTO AddPerson(DateTime birthDate, string firstName, string lastName, string middleName)
        {
            var person = new Person
            {
                BirhDate = birthDate,
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName
            };
            _personRepository.Create(person);
            return _mapper.Map<PersonWithoutLibraryCardsDTO>(person);
        }
        public PersonWithoutLibraryCardsDTO EditPerson(PersonWithoutLibraryCardsDTO personDTO)
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
            return _mapper.Map<PersonWithoutLibraryCardsDTO>(person);
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
        public IEnumerable<PersonWithoutLibraryCardsDTO> GetAllPersons()
        {
            return _personRepository.Get().Select(p => _mapper.Map<PersonWithoutLibraryCardsDTO>(p));
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
