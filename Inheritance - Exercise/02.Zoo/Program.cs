using System;

namespace _02.Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("Garo");
            Console.WriteLine(bear.Name);
        }
    }
}

