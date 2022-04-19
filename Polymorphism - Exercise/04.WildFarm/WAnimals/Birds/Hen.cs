﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Birds
{
    public class Hen: Bird
    {
        private const double BaseModifier = 0.35;
        private static HashSet<string> henAllowedFoods = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, henAllowedFoods, BaseModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
