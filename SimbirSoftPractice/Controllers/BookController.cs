using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimbirSoftPractice.EF;
using SimbirSoftPractice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private UnitOfWork unitOfWork;

        public BookController(LibraryDBContext db)
        {
            unitOfWork = new UnitOfWork(db);
        }

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return unitOfWork.Books.GetAll();
        }

        [HttpPost(template:"AddBook")]
        public void AddBook([FromBody] Book book)
        {

        }

        [HttpDelete]
        public void RemoveBook([FromQuery] int id)
        {

        }
    }
}
