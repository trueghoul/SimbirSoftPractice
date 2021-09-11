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
        public IEnumerable<LibraryCard> TakeABook([FromBody] LibraryCard libraryCard)
        {
            FakeRepository.Cards.Add(libraryCard);
            return FakeRepository.Cards;
        }

        [HttpGet]
        public IEnumerable<LibraryCard> GetCards()
        {
            return FakeRepository.Cards;
        }
    }
}
