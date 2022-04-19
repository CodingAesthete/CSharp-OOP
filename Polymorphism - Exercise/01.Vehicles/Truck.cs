using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptiomn) 
            : base(fuelQuantity, fuelConsumptiomn)
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
            liters = (liters * 95) / 100;
            FuelQuantity += liters;
        }
    }
}
