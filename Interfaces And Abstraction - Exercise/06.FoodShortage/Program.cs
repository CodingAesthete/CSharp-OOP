using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> sorted = new Dictionary<string, IBuyer>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length==3)
                {
                    IBuyer rebel= new Rebel(input[0],int.Parse(input[1]),input[2]);
                    sorted.Add(input[0], rebel);
                }
                else if (input.Length==4)
                {
                    IBuyer citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    sorted.Add(input[0], citizen);
                }
            }
            string name;
            while ((name=Console.ReadLine())!="End")
            {
                if (!sorted.ContainsKey(name))
                {
                    continue;
                }
                else
                {
                    var curr = sorted[name];
                    curr.BuyFood();
                }
            }
            Console.WriteLine(sorted.Values.Sum(s=>s.Food));
        }
    }
}
