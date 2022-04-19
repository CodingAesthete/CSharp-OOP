using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCaloriesa
{
    public class Pizza
    {
        private const int NameMinLength = 1;
        private const int NameMaxLength = 15;
        private const int MinCountToppings = 0;
        private const int MaxCountToppings = 10;
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }
        public string Name 
        { 
            get 
            {
                return this.name;
            } 
            private set 
            {
                if (value.Length < NameMinLength || value.Length > NameMaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between {NameMinLength} and {NameMaxLength} symbols.");
                }
                this.name = value;
            } 
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count==MaxCountToppings)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [{MinCountToppings}..{MaxCountToppings}].");
            }
            toppings.Add(topping);
        }

        public double GetCalories()
        {
            return dough.GetCalories() + toppings.Sum(s=>s.GetCalories());
        }
    }
}
