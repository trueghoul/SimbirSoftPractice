using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice
{
    public class LibraryCard
    {
        public Human Reader { get; set; }
        public Book Book { get; set; }
        public DateTimeOffset StartOfLease { get; set; }
    }
}
