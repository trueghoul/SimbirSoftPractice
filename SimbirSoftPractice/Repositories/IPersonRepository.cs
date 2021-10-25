using SimbirSoftPractice.Models;
using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        List<LibraryCard> GetLibraryCards(int personId);
        LibraryCard AddLibraryCard(int personId, int bookId);
        void RemoveLibraryCard(int personId, int bookId);
    }
}
