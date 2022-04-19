using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> all = new List<IBirthable>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parameters = input.Split();
                if (parameters[0] == "Robot")
                {
                    IIdentifiable robot = new Robot(parameters[1], parameters[2]);
                }
                else if (parameters[0] == nameof(Citizen))
                {
                    IBirthable citizen = new Citizen(parameters[1], int.Parse(parameters[2]), parameters[3], parameters[4]);
                    all.Add(citizen);
                }
                else if (parameters[0] == nameof(Pet))
                {
                    IBirthable pet = new Pet(parameters[1], parameters[2]);
                    all.Add(pet);
                }
            }
            string year = Console.ReadLine();
            List<IBirthable> birthables = all.Where(s => s.Birthdate.EndsWith(year)).ToList();
            foreach (var inhabitant in birthables)
            {
                Console.WriteLine(inhabitant.Birthdate);
            }
        }
    }
}
