using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight, HashSet<string> allowedFoods, double weightModifier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFoods;
            WeightModifier = weightModifier;
        }
        private double WeightModifier { get; set; }
        private HashSet <string> AllowedFoods { get;  set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public abstract string ProduceSound();
        public void Eat(Food food)
        {
            if (!AllowedFoods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten += food.Quantity;
            Weight += this.WeightModifier * food.Quantity;
        }
    }
}
