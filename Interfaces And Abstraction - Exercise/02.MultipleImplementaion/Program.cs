using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            string id = Console.ReadLine();
            string birthday = Console.ReadLine();
            IIdentifiable indefitable = new Citizen(name, age,id,birthday);
            IBirthable birthable = new Citizen(name, age, id, birthday);
            Console.WriteLine(indefitable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
