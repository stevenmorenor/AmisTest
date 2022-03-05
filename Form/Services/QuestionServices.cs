using AmisTest.Data;
using AmisTest.Models;
using AmisTest.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmisTest.Services
{
    public class QuestionServices : IQuestionServices
    {
        private readonly ApplicationContext applicationContext;

        public QuestionServices(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        

        public async Task<IEnumerable<Question>> GetAllQuestion()
        {
            var result = await applicationContext.Questions.ToListAsync();
            return result;
        }
    }
}
