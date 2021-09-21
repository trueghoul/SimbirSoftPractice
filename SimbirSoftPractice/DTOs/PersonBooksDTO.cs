using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.DTOs
{
    public class PersonBooksDTO
    {
        string BookName { get; set; }
        string AuthorName { get; set; }
        string[] Genres { get; set; }

    }
}
