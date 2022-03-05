using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PizzaService : IPizzaService
    {
        private static IList<Pizza> pizzas = new List<Pizza>();

        public void CreatePizza(Pizza pizza)
        {
            if (pizza.Name == "pollo")
            {
                throw new Exception();
            }
            pizzas.Add(pizza);
        }

        public IEnumerable<Pizza> GetAllPizza()
        {
            return pizzas.ToList();
        }
        public Pizza GetPizzaById(int id)
        {
            var pizza = pizzas.FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                throw new Exception();
            }
            return pizza;
        }
    }
}
