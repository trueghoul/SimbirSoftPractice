using System;
using System.Collections.Generic;

#nullable disable

namespace SimbirSoftPractice.EF
{
    public partial class Genre
    {
        public Genre()
        {
            BookGenres = new HashSet<BookGenre>();
        }

        public int Id { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
