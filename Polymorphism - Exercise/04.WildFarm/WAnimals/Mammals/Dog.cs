using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double BaseModifier = 0.40;
        private static HashSet<string> mouseAllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, mouseAllowedFoods, BaseModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
