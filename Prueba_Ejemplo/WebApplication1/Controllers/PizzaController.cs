using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        
        private readonly ILogger<PizzaController> _logger;
        private readonly IPizzaService pizzaService;

        public PizzaController(ILogger<PizzaController> logger, IPizzaService pizzaService)
        {
            _logger = logger;
            this.pizzaService = pizzaService;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Pizza>> Get()
        {
            return Ok(pizzaService.GetAllPizza());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Pizza pizza)
        {
            
            return Ok(pizza);
        }

        [HttpGet("{id}")]
        public  ActionResult<Pizza> GetById([FromRoute]int id)
        {
            var pizza = pizzaService.GetPizzaById(id);
            return Ok(pizza);
        }
    }
}
