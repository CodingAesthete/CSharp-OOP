using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Restaurant
{
    public class Fish : MainDish
    {
        private const int DefaultGrams = 22;
        public Fish(string name, decimal price) : base(name, price, DefaultGrams)
        {
        }
    }
}

