using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Restaurant
{
    public class Beverage : Product
    {
        public double Milliliters { get; set; }
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
    }
}

