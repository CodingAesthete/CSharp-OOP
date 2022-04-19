using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double BaseModifier = 0.10;
        private static HashSet<string> mouseAllowedFoods = new HashSet<string>()
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(string name, double weight,  string livingRegion) 
            : base(name, weight, mouseAllowedFoods, BaseModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
