using System;

namespace CollHerra
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddCollection<string> addColl = new AddCollection<string>();
            AddRemoveCollection<string> addRemCool = new AddRemoveCollection<string>();
            MyList<string> myList = new MyList<string>();
            string[] inputs = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());
            foreach (var item in inputs)
            {
                Console.Write(addColl.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in inputs)
            {
                Console.Write(addRemCool.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in inputs)
            {
                Console.Write(myList.Add(item) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.Write(addRemCool.Remove()+ " ");
            }
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
