using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
        public Vehicle(double fuelQuantity,double fuelConsumptiomn)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumptiomn;
        }
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
