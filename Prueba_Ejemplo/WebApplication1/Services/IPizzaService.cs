using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPizzaService
    {
        void CreatePizza(Pizza pizza);
        IEnumerable<Pizza> GetAllPizza();
        Pizza GetPizzaById(int id);
    }
}
