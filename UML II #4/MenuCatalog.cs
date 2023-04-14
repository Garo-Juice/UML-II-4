using System;
using System.Collections.Generic;
namespace UML2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            foreach(Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }

        }

        public Pizza FindPizzaById(int id)
        { 
          return _pizzas.FirstOrDefault(p => p.Id == p.Id);
                
        }

        public void Update(int id, Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (id == p.Id)
                {
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                    break;
                }

                    
            }
            
        }

        public void Delete(int id)
        {
            _pizzas.RemoveAll(p => p.Id == id);
        }


    }
}