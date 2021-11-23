using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Models
{
    public class LibraryCardWithoutPersonDTO
    {
        public int BookId { get; set; }
        public BookWithoutLibraryCardsDTO Book { get; set; }
    }
}
