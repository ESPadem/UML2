using System;
using System.Collections.Generic;

namespace PizzaStore2
{
    public class MenuCatalog
    {
        //globale variabler
        private List<Pizza> pizzas = new List<Pizza>();

        //constructors
        public MenuCatalog()
        {
            Pizza p = CreatePizza(1, "margaritha", 69);
            Pizza p1 = CreatePizza(2, "vesuvio", 75);
            Pizza p2 = CreatePizza(3, "carpacciosa", 78);
            pizzas.Add(p);
            pizzas.Add(p1);
            pizzas.Add(p2);
        }
        //create metode
        public Pizza CreatePizza(int id, string name, double price)
        {
            Pizza p = new Pizza(id, name, price);
            return p;
        }
        //add metode
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza); 
        }
        //delete metode
        public void DeletePizza(int id)
        {
            foreach(Pizza p in pizzas)
            {
                if (p.GetID() == id)
                {
                    pizzas.Remove(p);
                    break;
                }
            }
        }
        //update og search metode
        public void UpdatePizza(int search, string updatePizza, double price)
        {
            try
            {
                foreach (Pizza p in pizzas)
                {
                    if (p.GetID() ==  search)
                    {
                        p.SetName(updatePizza);
                        p.SetPrice(price);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //print metode, hvis mindre end 1, så "no pizzas in the menu
        public void PrintMenu()
        {
            if (pizzas.Count < 1)
            {
                Console.WriteLine("No pizzas in the menu");
            }
            else
            {
            foreach (Pizza p in pizzas)
            {
                Console.WriteLine(p + "\n");
            }
            }
        }
        //search metode, "ToLower" hvilken som helst bogstave kan søges
        public List<Pizza> SearchPizza(string criteria)
        {
            string criteriaToSearch = criteria.ToLower();
            bool isPizzaFound = false;
            List<Pizza> searchPizzas = new List<Pizza>();
            if(pizzas.Count < 1)
            {
                Console.WriteLine("No pizzas in the menu to search for");
            }
            foreach (Pizza p in pizzas)
            {
                if (p.GetName().ToLower().Contains(criteriaToSearch))
                {
                    isPizzaFound = true;
                    searchPizzas.Add(p);
                }
             
            }
            if (!isPizzaFound)
            {
                Console.WriteLine("The searched keyword " + criteria + " has not been found in menu");
            }
            return searchPizzas;
        }
   
    }
}