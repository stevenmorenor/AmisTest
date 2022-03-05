using AmisTest.Models;
using AmisTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmisTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionServices questionServices;
        public QuestionController(IQuestionServices questionServices)
        {
            this.questionServices = questionServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> Get()
        {
            var result = await questionServices.GetAllQuestion();
            return Ok(result);
        }
    }
}
