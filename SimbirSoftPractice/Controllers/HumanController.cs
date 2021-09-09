using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanController : ControllerBase
    {

        [HttpGet(template: "getAllHumans")]
        public IEnumerable<Human> GetAllHumans([FromQuery] string partOfFullName)
        {
            if (partOfFullName != null)
            {
                return FakeRepository.Humans.Where(p => p.Name.Contains(partOfFullName) || p.Surname.Contains(partOfFullName) ||
                                            (p.Patronymic != null && p.Patronymic.Contains(partOfFullName)));
            }
            else
            {
                return FakeRepository.Humans;
            }
        }

        [HttpGet(template: "getWriters")]
        public IEnumerable<Human> GetWriters([FromQuery] string partOfFullName)
        {
            List<Human> answer = new List<Human>();

            if (partOfFullName != null)
            {
                foreach (var book in FakeRepository.Books)
                {
                    answer.AddRange(FakeRepository.Humans.Where(p => p.Id == book.AuthorId && !answer.Contains(p) &&
                                                               (p.Name.Contains(partOfFullName) || p.Surname.Contains(partOfFullName) ||
                                                               (p.Patronymic != null && p.Patronymic.Contains(partOfFullName)))));
                }
            }
            else
            {
                foreach (var book in FakeRepository.Books)
                {
                    answer.AddRange(FakeRepository.Humans.Where(p => p.Id == book.AuthorId && !answer.Contains(p)));
                }
            }

            return answer;
        }

        [HttpPost]
        public void AddHuman([FromBody] Human human)
        {
            FakeRepository.Humans.Add(human);
        }

        [HttpDelete]
        public void RemoveHuman([FromQuery] int id)
        {
            FakeRepository.Humans.Remove(FakeRepository.Humans.Find(p => p.Id == id));
        }

    }
}
