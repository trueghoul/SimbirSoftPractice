using System;
using System.Collections.Generic;


namespace SimbirSoftPractice.Entites
{
    public class Person
    {
        public int Id { get; set; }
        public DateTime BirhDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public ICollection<LibraryCard> LibraryCards { get; set; }
    }
}
