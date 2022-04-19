using System;
using System.Collections.Generic;
using WildFarmIII.Animals;
using WildFarmIII.Animals.Birds;
using WildFarmIII.Animals.Mammals;
using WildFarmIII.Animals.Mammals.Felines;
using WildFarmIII.Foods;

namespace WildFarmIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string line;
            while ((line=Console.ReadLine())!="End")
            {
                string[] animalsParts = line.Split();
                Animal animal = CreateAnimal(animalsParts);
                animals.Add(animal);
                string[] foodParts = Console.ReadLine().Split();
                Food food = CreateFood(foodParts);
                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex )
                {

                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] parts)
        {
            string type = parts[0];
            int quantity = int.Parse(parts[1]);
            Food food = null;
            if (type==nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type==nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type==nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type==nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            return food;
        }

        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];
            Animal animal = null;
            string name = parts[1];
            double weight = double.Parse(parts[2]);
            if (type==nameof(Hen))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type==nameof(Owl))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type==nameof(Mouse))
            {
                string livingRegion = parts[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == nameof(Dog))
            {
                string livingRegion = parts[3];
                animal = new Dog(name, weight, livingRegion);
            }
            else if (type==nameof(Cat))
            {
                string livingRegion = parts[3];
                string breed = parts[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Tiger))
            {
                string livingRegion = parts[3];
                string breed = parts[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            return animal;
        }
    }
}
