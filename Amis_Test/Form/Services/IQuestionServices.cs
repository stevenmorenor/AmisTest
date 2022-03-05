using AmisTest.Models;
using AmisTest.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmisTest.Services
{
    public interface IQuestionServices
    {
        Task<IEnumerable<Question>> GetAllQuestion();

    }
}
