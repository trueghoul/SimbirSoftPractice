using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository 
    {
        public PersonRepository(LibraryDBContext context)
            :base(context)
        {

        }
        public LibraryDBContext LibraryDBContext
        {
            get { return Context as LibraryDBContext; }
        }
    }
}
