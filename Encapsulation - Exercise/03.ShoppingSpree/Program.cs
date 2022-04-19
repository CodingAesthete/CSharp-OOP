using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> dict1 = new Dictionary<string, Person>();
            Dictionary<string, Product> dict2 = new Dictionary<string, Product>();
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string[] input2 = input[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = input2[0];
                    decimal money = decimal.Parse(input2[1]);
                    Person person = new Person(name, money);
                    dict1[name] = person;
                }
                string [] input3 = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input3.Length; i++)
                {
                    string[] input4 = input3[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = input4[0];
                    decimal cost = decimal.Parse(input4[1]);
                    Product product = new Product(name, cost);
                    dict2[name] = product;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string input5;
            while ((input5=Console.ReadLine())!="END")
            {
                string[] input6 = input5.Split();
                string person = input6[0];
                string product = input6[1];
                Person curr = dict1[person];
                Product curro = dict2[product];
                try
                {
                    curr.AddProduct(curro);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var person in dict1.Values)
            {
                Console.WriteLine(person );
            }
        }
    }
}
