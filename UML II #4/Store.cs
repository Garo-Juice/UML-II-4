using System;

namespace UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;

        public Store()
        { 
            menuCatalog = new MenuCatalog();
        }
        public void Test()
        {   
            Pizza p =new Pizza(){Id=1, Name="Pepperoni#1", Price=50};
            menuCatalog.Create(p);

            p =new Pizza(){Id=2, Name="Kebab", Price=55};
            menuCatalog.Create(p);

            p =new Pizza(){Id=3, Name="Shrimp", Price=65};
            menuCatalog.Create(p);

            menuCatalog.PrintMenu();
            

            /*Console.WriteLine();
            int pizzaToBeFound = 2;
            Console.WriteLine($"Finding Pizza {pizzaToBeFound}");
            Pizza foundPizza = menuCatalog.Read(pizzaToBeFound);
            Console.WriteLine(foundPizza);

            Console.WriteLine();
            string searchCriteria = "PIZZA#1";
            Console.WriteLine($"Finding Pizza starting with: {searchCriteria}");
            foundPizza = menuCatalog.SearchPizza(searchCriteria);
            Console.WriteLine(foundPizza);

            Console.WriteLine();
            Console.WriteLine($"Updating Pizza #{foundPizza.Number}");
            foundPizza.Name += " (Updated)";
            menuCatalog.Update(foundPizza);

            Console.WriteLine();
            menuCatalog.PrintMenu();

            Console.WriteLine();
            int pizzaToBeDeleted = 2;
            Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            menuCatalog.Delete(pizzaToBeDeleted);
            Console.WriteLine();
            menuCatalog.PrintMenu();*/

        }

        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
    }
}