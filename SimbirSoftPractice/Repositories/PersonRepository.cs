using Microsoft.EntityFrameworkCore;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository 
    {
        public PersonRepository(LibraryDBContext context)
            :base(context)
        {

        }

        public List<LibraryCard> GetLibraryCards(int personId)
        {
            return _context.LibraryCards
                .Where(lc => lc.PersonId == personId)
                .Include(lc => lc.Book)
                    .ThenInclude(b => b.Author)
                .Include(lc => lc.Book)
                    .ThenInclude(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                .ToList();
        }
        public LibraryCard AddLibraryCard(int personId, int bookId)
        {
            var libraryCard = new LibraryCard
            {
                PersonId = personId,
                BookId = bookId
            };
            _context.LibraryCards.Add(libraryCard);
            _context.SaveChanges();
            return libraryCard;
        }

        public void RemoveLibraryCard(int personId, int bookId)
        {
            var libraryCard = _context.LibraryCards.Where(lc => lc.PersonId == personId && lc.BookId == bookId).FirstOrDefault();
            _context.LibraryCards.Remove(libraryCard);
            _context.SaveChanges();
        }
    }
}
