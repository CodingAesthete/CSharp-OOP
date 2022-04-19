﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
    public class Kitten : Cat
    {
        private const string DefaultGender = "Female";
        public Kitten(string name, int age) : base(name, age, DefaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

