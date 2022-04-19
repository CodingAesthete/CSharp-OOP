using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> all = new List<IIdentifiable>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] parameters = input.Split();
                if (parameters.Length==2)
                {
                    IIdentifiable robot = new Robot(parameters[0], parameters[1]);
                    all.Add(robot);
                }
                else if (parameters.Length==3)
                {
                    IIdentifiable citizen = new Citizen(parameters[0], int.Parse(parameters[1]), parameters[2]);
                    all.Add(citizen);
                }
            }
            string ending = Console.ReadLine();
            foreach (var inhabitant in all)
            {
                if (inhabitant.Id.EndsWith(ending))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }
    }
}
