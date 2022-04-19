using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity,double airConditionserModifier)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            AirConditionerModifier = airConditionserModifier;
            if (FuelQuantity>TankCapacity)
            {
                FuelQuantity = 0;
            }
        }
        protected double AirConditionerModifier { get; set; }
        public double TankCapacity { get; protected set; }
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
       
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
