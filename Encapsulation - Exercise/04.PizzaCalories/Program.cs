using System;

namespace PizzaCaloriesa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaData = Console.ReadLine().Split();
                string[] doughData = Console.ReadLine().Split();
                Dough dough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));
                Pizza pizza = new Pizza(pizzaData[1], dough);
                string input;
                while ((input=Console.ReadLine())!="END")
                {
                    string [] toppingData = input.Split();
                    Topping topping = new Topping(toppingData[1], double.Parse(toppingData[2]));
                    pizza.AddTopping(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
