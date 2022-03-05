using AmisTest.Data;
using AmisTest.Models;
using AmisTest.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmisTest.Services
{
    public class FormServices : IFormServices
    {
        private readonly ApplicationContext applicationContext;

        public FormServices(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task<Models.Form> CreateForms(Models.Form form)
        {
            if (form?.Person == null)
            {
                throw new ArgumentException("Person can not be null");
            }
            applicationContext.Forms.Add(form);
            await applicationContext.SaveChangesAsync();
            return form;
        }

        public async Task<IEnumerable<FormDto>> GetAllForm()
        {
            var result = await applicationContext.Forms
                .Include(f => f.Person)
                .Include(f => f.Question)
                .Select(f => new FormDto
                {
                    FormId = f.FormId,
                    Question = f.Question.Description,
                    Name = f.Person.Name + " " + f.Person.LastName,
                    Answer = f.Answer
                }).ToListAsync();
            return result;
        }

        public async Task<FormDto> GetFormsById(Guid id)
        {
            var result = await applicationContext.Forms
                .Include(f => f.Person)
                .Include(f => f.Question)
                .Select(f => new FormDto
                {
                    FormId = f.FormId,
                    Question = f.Question.Description,
                    Name = f.Person.Name + " " + f.Person.LastName,
                    Answer = f.Answer
                }).FirstOrDefaultAsync(p => p.FormId == id);
            return result;
        }

    }
}
