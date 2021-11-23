using System;
using System.Collections.Generic;

namespace SimbirSoftPractice.Entites
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
