using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriesa
{
    public class Topping
    {
        private string type;
        private double weight;
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type 
        { 
            get 
            {
                return this.type;
            } 
            private set
            {
                string valueToLower = value.ToLower();
                if (valueToLower!= "meat" && valueToLower!= "veggies" && valueToLower!= "cheese" && valueToLower!= "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            } 
        }
        public double Weight 
        { 
            get 
            {
                return this.weight;
            }
            private set 
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                this.weight = value;
            } 
        }
        public double GetCalories()
        {
            double modifier = GetModifier();
            return 2 * Weight * modifier;
        }

        private double GetModifier()
        {
            string typeToLower = this.Type.ToLower();
            if (typeToLower== "meat")
            {
                return 1.2;
            }
            else if (typeToLower== "veggies")
            {
                return 0.8;
            }
            else if (typeToLower== "cheese")
            {
                return 1.1;
            }
            return 0.9;
        }
    }
}
