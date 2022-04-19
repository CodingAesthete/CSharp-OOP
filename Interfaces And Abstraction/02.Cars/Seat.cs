﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public void Start()
        {
            Console.WriteLine("Engine start");
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
        public override string ToString()
        {
            string res = $"{this.Color} Seat {this.Model}";
            return res;
        }
    }
}