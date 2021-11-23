using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Models
{
    public class BookWithoutLibraryCardsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AuthorDTO Author { get; set; }
        public ICollection<BookGenreWithoutBookDTO> BookGenres { get; set; }
    }
}
