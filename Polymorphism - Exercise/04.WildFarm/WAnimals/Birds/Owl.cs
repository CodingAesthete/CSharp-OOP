using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Birds
{
    public class Owl : Bird
    {
        private const double BaseModifier = 0.25;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, owlAllowedFoods, BaseModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
