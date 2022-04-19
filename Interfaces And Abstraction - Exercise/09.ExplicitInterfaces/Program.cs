using System;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line=Console.ReadLine())!="End")
            {
                string[] input = line.Split();
                IPerson person = new Citizen(input[0], input[1], int.Parse(input[2]));
                IResident resident = new Citizen(input[0], input[1], int.Parse(input[2]));
                person.GetName();
                resident.GetName();
            }
        }
    }
}
