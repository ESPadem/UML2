using System;

namespace PizzaStore2
{
    public class Pizza
    {
        //globale variabler
        public int id;
        public string name;
        public double price;

        //constructors
        public Pizza(int id, string name, double price)
        {
            //referere til de globale variabler
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double price)
        { 
            this.price = price;
        }
        public double GetDouble()
        {
            return price;
        }
        public override string ToString()
        {
            return $"pizza id: " + this.id + "\n" + "pizza: " + this.name + "\n" + "price: " + this.price;
        }
    }
}