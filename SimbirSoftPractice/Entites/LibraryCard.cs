using System;
using System.Collections.Generic;

namespace SimbirSoftPractice.Entites
{
    public class LibraryCard
    {
        public int BookId { get; set; }
        public int PersonId { get; set; }

        public Book Book { get; set; }
        public Person Person { get; set; }
    }
}
