using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            StationaryPhone stat = new StationaryPhone("Nokia");
            Smartphone smartphone = new Smartphone("Nokia");

            string[] phones = Console.ReadLine().Split();
            foreach (var phone in phones)
            {
                if (phone.Length==7)
                {
                    stat = new StationaryPhone(phone);
                    Console.WriteLine(stat.Call(phone));
                }
                else
                {
                    smartphone = new Smartphone(phone);
                    Console.WriteLine(smartphone.Call(phone));
                }
                
            }
            string[] websites = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var website in websites)
            {
                Console.WriteLine(smartphone.Browse(website));
            }
        }
    }
}
