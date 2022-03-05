using AmisTest.Models.Dtos;
using AmisTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmisTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormServices formServices;
        private readonly ILogger<FormController> logger;

        public FormController(IFormServices formServices, ILogger<FormController> logger)
        {
            this.formServices = formServices;
            this.logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Models.Form form)
        {
            var result = await formServices.CreateForms(form);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormDto>>> Get()
        {
            var result = await formServices.GetAllForm();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FormDto>> GetById([FromRoute] Guid id)
        {
            var person = await formServices.GetFormsById(id);
            return Ok(person);
        }
        

    }
}
