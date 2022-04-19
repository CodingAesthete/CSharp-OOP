using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirConditioner = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity,AirConditioner)
        {
        }
        public void OnConditioner()
        {
            this.AirConditionerModifier = AirConditioner;
        }
        public void OffConditioner()
        {
            this.AirConditionerModifier = 0;
        }

        public override void Drive(double distance)
        {
            double Consumption = FuelConsumption + AirConditionerModifier;
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
            if (liters<=0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (FuelQuantity+liters>TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    FuelQuantity += liters;
                }
            }
        }
    }
}
