using System;
using System.Collections.Generic;

namespace SimbirSoftPractice.Entites
{
    public partial class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
