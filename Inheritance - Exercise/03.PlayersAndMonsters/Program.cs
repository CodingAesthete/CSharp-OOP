using System;

namespace _03.PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BladeKnight bald = new BladeKnight("Haro", 23);
            Console.WriteLine(bald.Username);
            Console.WriteLine(bald.Level);
        }
    }
}

