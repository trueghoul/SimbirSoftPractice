using System;
using System.Collections.Generic;

namespace SimbirSoftPractice.Entites
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<LibraryCard> LibraryCards { get; set; }
    }
}
