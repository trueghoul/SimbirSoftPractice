using System;
using System.Collections.Generic;

#nullable disable

namespace SimbirSoftPractice.EF
{
    public partial class Person
    {
        public Person()
        {
            LibraryCards = new HashSet<LibraryCard>();
        }

        public int Id { get; set; }
        public DateTime BirhDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public virtual ICollection<LibraryCard> LibraryCards { get; set; }
    }
}
