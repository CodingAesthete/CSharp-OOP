using System;

namespace _04.NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RaceMotorcycle racer = new RaceMotorcycle(100, 100);
            racer.Drive(10);
            Console.WriteLine(racer.Fuel);
        }
    }
}
