using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Models
{
    public class BookGenreWithoutBookDTO
    {
        public int GenreId { get; set; }
        public GenreWithoutBookGenresDTO Genre { get; set; }
    }
}
