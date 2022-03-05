using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            this.personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> Get()
        {
            return Ok(await personService.GetAllPerson());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Person person)
        {
            await personService.CreatePerson(person);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetById([FromRoute] int id)
        {
            var person = await personService.GetPersonById(id);
            return Ok(person);
        }
    }
}
