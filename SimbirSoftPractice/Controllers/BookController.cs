using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        [HttpGet]
        public IEnumerable<Book> GetBooks([FromQuery] int? AuthorId)
        {
            if (AuthorId != null)
            {
                return FakeRepository.Books.Where(p => p.AuthorId == AuthorId);
            }
            else return FakeRepository.Books;
        }

        [HttpPost]
        public void AddBook([FromBody] Book book)
        {
            FakeRepository.Books.Add(book);
        }

        [HttpDelete]
        public void RemoveBook([FromQuery] int id)
        {
            FakeRepository.Books.Remove(FakeRepository.Books.Find(p => p.Id == id));
        }
    }
}
