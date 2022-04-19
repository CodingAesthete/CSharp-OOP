using System;

namespace _06.Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                string gender = data[2];
                if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (input == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog);
                    Console.WriteLine(dog.ProduceSound());
                }
                else if (input == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat);
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (input == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog);
                    Console.WriteLine(frog.ProduceSound());
                }
                else if (input == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(kitten);
                    Console.WriteLine(kitten.ProduceSound());
                }
                else if (input == "Tomcat")
                {
                    Tomcat tom = new Tomcat(name, age);
                    Console.WriteLine(tom);
                    Console.WriteLine(tom.ProduceSound());
                }
            }
        }
    }
}
