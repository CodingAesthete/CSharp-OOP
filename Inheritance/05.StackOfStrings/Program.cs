using System;
using System.Collections.Generic;

namespace _05.StackOfStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stacko = new Stack<string>();
            stacko.Push("Aro");
            stacko.Push("Baro");
            stacko.Push("Haro");
            StackOfStrings stecko = new StackOfStrings();
            stecko.AddRange(stacko);
            foreach (var item in stecko)
            {
                Console.WriteLine(item);
            }
        }
    }
}
