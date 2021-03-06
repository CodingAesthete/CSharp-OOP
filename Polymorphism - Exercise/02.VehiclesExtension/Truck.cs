using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditioner = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity,AirConditioner)
        {
        }

        public override void Drive(double distance)
        {
            double Consumption = FuelConsumption + 1.6;
            double total = Consumption * distance;
            if (total <= FuelQuantity)
            {
                FuelQuantity -= total;
                Console.WriteLine($"{this.GetType().Name} travelled { distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (this.FuelQuantity + liters > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    liters = (liters * 95) / 100;
                    FuelQuantity += liters;
                }
            }
            
        }
    }
}
