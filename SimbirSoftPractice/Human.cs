using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoftPractice
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birhday { get; set; }

        public static IEnumerable<Human> FindAllByFullName (string partOfFullName)
        {
            return FakeRepository.Humans.Where(p => p.Name.Contains(partOfFullName) || p.Surname.Contains(partOfFullName) ||
                                            (p.Patronymic != null && p.Patronymic.Contains(partOfFullName)));
        }

    }
}
