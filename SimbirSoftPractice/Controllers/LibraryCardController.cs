using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryCardController : ControllerBase
    {
        [HttpPost]
        public void TakeABook([FromBody] LibraryCard libraryCard)
        {
            FakeRepository.Cards.Add(libraryCard);
        }

        [HttpGet]
        public IEnumerable<LibraryCard> GetCards()
        {
            return FakeRepository.Cards;
        }
    }
}
