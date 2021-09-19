using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDBContext context)
            :base(context)
        {

        }
        public LibraryDBContext LibraryDBContext
        {
            get { return Context as LibraryDBContext; }
        }
    }
}
