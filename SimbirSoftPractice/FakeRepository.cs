using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice
{
    public static class FakeRepository
    {
        public static List<Human> Humans = new List<Human>
        {
            new Human{Id = 1, Name = "Ivan", Surname = "Efimov", Patronymic = "Anatolevich", Birhday = new DateTime(2000,11,27)},
            new Human{Id = 2, Name = "Sui", Surname = "Ishida", Birhday = new DateTime(1986,12,28)},
            new Human{Id = 3, Name = "Hajime", Surname = "Isayama", Birhday = new DateTime(2000,8,10)}
        };

        public static List<Book> Books = new List<Book>
        {
            new Book{Id = 1, AuthorId = 2, Title = "Tokyo Ghoul", Genre = "Dark fantasy"},
            new Book{Id = 2, AuthorId = 2, Title = "Tokyo Ghoul:re", Genre = "Dark fantasy"},
            new Book{Id = 3, AuthorId = 3, Title = "Attack on titan", Genre = "thriller"}
        };

        public static List<LibraryCard> Cards = new List<LibraryCard>();
    }
}
