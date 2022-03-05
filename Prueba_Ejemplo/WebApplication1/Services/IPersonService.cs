﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPersonService
    {
        Task CreatePerson(Person person);
        Task<IEnumerable<Person>> GetAllPerson();
        Task<Person> GetPersonById(int id);

    }
}
