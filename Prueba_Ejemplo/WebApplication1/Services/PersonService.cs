using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PersonService : IPersonService
    {
        private static IList<Person> people = new List<Person>();

        public async Task CreatePerson(Person person)
        {
            await Task.CompletedTask;
            if (person.Name == "Steven")
            {
                throw new Exception();
            }
            people.Add(person);
        }

        public async Task<IEnumerable<Person>> GetAllPerson()
        {
            await Task.CompletedTask;
            return people.ToList();
        }

        public async Task<Person> GetPersonById(int id)
        {
            await Task.CompletedTask;
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                throw new Exception();
            }
            return person;
        }
    }
}
