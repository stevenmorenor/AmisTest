using AmisTest.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmisTest.Services
{
    public interface IFormServices
    {
        Task<Models.Form> CreateForms(Models.Form form);
        Task <IEnumerable<FormDto>> GetAllForm();
        Task <FormDto> GetFormsById(Guid id);
    }
}
