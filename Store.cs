using System;
using System.Collections.Generic;

namespace PizzaStore2
{
    public class Store
    {
        private static MenuCatalog menu = new MenuCatalog();
        public Store()
        {
       
        }
        public void Start()
        {
            //while loop
            while (true)
            {
                PrintDialog();
                int id = Convert.ToInt32(Console.ReadLine());
                if (id == 6)
                {
                    break;
                }
                Choose(id);
            }
        }
        //print dialog metode
        public void PrintDialog()
        {
            Console.WriteLine("1. Add new pizza");
            Console.WriteLine("2. Delete pizza");
            Console.WriteLine("3. Update pizza");
            Console.WriteLine("4. Search pizza");
            Console.WriteLine("5. Display pizza menu");
            Console.WriteLine("6. Exit");
        }
        //choose metode
        public static void Choose(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("Insert pizza id.");
                int pizza = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert name of pizza.");
                string name = Console.ReadLine();
                Console.WriteLine("Insert price of pizza.");
                double price = Convert.ToDouble(Console.ReadLine());
                Pizza p = menu.CreatePizza(pizza, name, price);
                menu.AddPizza(p);
            }
            else if (id == 2)
            {
                menu.PrintMenu();
                Console.WriteLine("Which pizza id, would you like to delete?");
                int pizza = Convert.ToInt32(Console.ReadLine());
                menu.DeletePizza(pizza);
            }
            else if (id == 3)
            {
                menu.PrintMenu();
                Console.WriteLine("Which pizza id, would you like to update?");
                int pizza = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insert new name");
                string updatePizza = Console.ReadLine();
                Console.WriteLine("insert new price");
                double price = Convert.ToDouble(Console.ReadLine());
                menu.UpdatePizza(pizza, updatePizza, price);
                menu.PrintMenu();
            }
            else if (id == 4)
            {
                Console.WriteLine("Which pizza, would you like to search?");
                string search = Console.ReadLine();
                List<Pizza> searchedPizzas = menu.SearchPizza(search);
                foreach (Pizza pizza in searchedPizzas)
                {
                    Console.WriteLine(pizza);
                }
            }
            else if (id == 5)
            {
                menu.PrintMenu();
            }
            else if (id == 6)
            {
                return;
            }

        }
    }
}