using System;

namespace _04.RandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("hella");
            list.Add("gella");
            list.Add("kella");
            string curr = list.RandomString();
            Console.WriteLine(curr);
        }
    }
}

