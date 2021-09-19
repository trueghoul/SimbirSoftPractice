using SimbirSoftPractice.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryDBContext _context;
        
        public UnitOfWork(LibraryDBContext context)
        {
            _context = context;
            Persons = new PersonRepository(_context);
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
            Genres = new GenreRepository(_context);
        }

        public IPersonRepository Persons { get; private set; }
        public IBookRepository Books { get; private set; }
        public IAuthorRepository Authors { get; private set; }
        public IGenreRepository Genres { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
