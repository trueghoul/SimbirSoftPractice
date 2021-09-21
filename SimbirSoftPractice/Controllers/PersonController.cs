using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimbirSoftPractice.DTOs;
using SimbirSoftPractice.EF;
using SimbirSoftPractice.Repositories;
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

        private UnitOfWork unitOfWork;

        public PersonController(LibraryDBContext db)
        {
            unitOfWork = new UnitOfWork(db);
        }

        [HttpPost]
        public Person AddPerson([FromBody] PersonDTO person)
        {
            var pers = unitOfWork.Persons.ToPersonMap(person);
            unitOfWork.Persons.Add(pers);
            unitOfWork.Complete();
            return unitOfWork.Persons.GetPerson(pers.Id);
        }

        [HttpPut]
        public Person EditPerson([FromBody] PersonDTO person)
        {
            unitOfWork.Persons.EditPerson(person);
            unitOfWork.Complete();
            return unitOfWork.Persons.GetPerson(person.Id);
        }

        [HttpDelete(template: "byID")]
        public ActionResult DeletePersonById([FromQuery] int id)
        {
            try
            {
                unitOfWork.Persons.DeletePerson(id);
                unitOfWork.Complete();
            }
            catch { return new StatusCodeResult(404); }
            return new StatusCodeResult(204);
        }

        [HttpDelete(template: "byFullName")]
        public ActionResult DeletePersonByFullName([FromQuery] string fullName)
        {
            try
            {
                unitOfWork.Persons.DeletePerson(fullName);
                unitOfWork.Complete();
            }
            catch { return new StatusCodeResult(404); }
            return new StatusCodeResult(204);
        }

    }
}
