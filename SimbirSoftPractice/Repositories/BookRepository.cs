using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDBContext context)
            :base(context)
        {

        }
    }
}
