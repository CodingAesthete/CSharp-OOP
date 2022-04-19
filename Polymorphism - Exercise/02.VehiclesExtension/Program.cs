using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(input[1]), double.Parse(input[2]),double.Parse(input[3]));
            string[] input2 = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(input2[1]), double.Parse(input2[2]),double.Parse(input2[3]));
            string[] input4 = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(input4[1]), double.Parse(input4[2]), double.Parse(input4[3]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input3 = Console.ReadLine().Split();
                if (input3[0]=="Drive")
                {
                    if (input3[1]=="Car")
                    {
                        car.Drive(double.Parse(input3[2]));
                    }
                    else if (input3[1]=="Truck")
                    {
                        truck.Drive(double.Parse(input3[2]));
                    }
                    else if (input3[1]=="Bus")
                    {
                        ((Bus)bus).OnConditioner();
                        bus.Drive(double.Parse(input3[2]));
                    }
                }
                else if (input3[0]=="DriveEmpty")
                {
                    ((Bus)bus).OffConditioner();
                    bus.Drive(double.Parse(input3[2]));
                    
                }
                else if (input3[0] == "Refuel")
                {
                    if (input3[1] == "Car")
                    {
                        car.Refuel(double.Parse(input3[2]));
                    }
                    else if (input3[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(input3[2]));
                    }
                    else if (input3[1]=="Bus")
                    {
                        bus.Refuel(double.Parse(input3[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
