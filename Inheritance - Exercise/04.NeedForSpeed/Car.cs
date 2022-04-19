﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return DefaultFuelConsumption;
            }
        }
    }
}

