﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual string ProduceSound()
        {
            return string.Empty;

        }
        public override string ToString()
        {
            return this.GetType().Name + Environment.NewLine + $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}