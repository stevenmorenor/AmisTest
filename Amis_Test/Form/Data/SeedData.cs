using System.Collections.Generic;
using AmisTest.Models;

namespace AmisTest.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationContext context)
        {
            var questions = new List<Question>()
            {
                new Question
                {
                    Description = "Cuales son tus hobbies favoritos?"
                }
                
            };
            context.Questions.AddRange(questions);
            context.SaveChanges();
        }
    }
}
