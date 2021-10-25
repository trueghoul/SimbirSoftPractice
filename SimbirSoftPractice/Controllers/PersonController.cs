using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Repositories;
using SimbirSoftPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonController
    {

        private readonly IPersonService _personService;
        public LibraryDBContext _context;

        public PersonController(IPersonService personService,
            LibraryDBContext context)
        {
            _context = context;
            _personService = personService;
        }

        [HttpGet(template: "GetAllPersons")]
        public IEnumerable<PersonWithoutLibraryCardsDTO> GetAll()
        {
            return _personService.GetAllPersons();
        }

        [HttpPost(template:"AddPerson")]
        public PersonWithoutLibraryCardsDTO Add([FromQuery] DateTime birthDate, string firstName, string lastName, string middleName)
        {
            return _personService.AddPerson(birthDate, firstName, lastName, middleName);
        }

        [HttpPut(template:"EditPerson")]
        public PersonWithoutLibraryCardsDTO Edit([FromBody] PersonWithoutLibraryCardsDTO person)
        {
            return _personService.EditPerson(person);
        }
        [HttpDelete(template:"RemovePerson")]
        public ActionResult RemoveById([FromQuery] int userId)
        {
            if (_personService.RemovePersonById(userId))
                return new StatusCodeResult(204);
            else return new StatusCodeResult(404);
        }
        [HttpDelete(template:"RemovePersonByFullName")]
        public ActionResult RemoveByFullName([FromQuery] string firstName, string lastName, string middleName)
        {
            if (_personService.RemovePersonByFullName(firstName, lastName, middleName))
                return new StatusCodeResult(204);
            else return new StatusCodeResult(404);
        }
        [HttpGet(template:"GetPersonBooks")]
        public IEnumerable<LibraryCardWithoutPersonDTO> GetPersonBooks([FromQuery] int userId)
        {
            return _personService.GetPersonBooks(userId);
        }
        [HttpPost(template:"AddPersonBook")]
        public LibraryCardDTO AddPersonBook([FromQuery] int personId, int bookId)
        {
            return _personService.AddPersonBook(personId, bookId);
        }
        [HttpDelete(template: "RemovePersonBook")]
        public void RempovePersonBook([FromQuery] int personId, int bookId)
        {
            _personService.RemovePersonBook(personId, bookId);
        }

    }
}
