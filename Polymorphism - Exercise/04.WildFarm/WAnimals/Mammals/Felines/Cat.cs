using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Mammals.Felines
{
    public class Cat : Feline
    {

        private const double BaseModifier = 0.30;
        private static HashSet<string> mouseAllowedFoods = new HashSet<string>()
        {
            nameof(Vegetable),
            nameof(Meat)
        };
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, mouseAllowedFoods, BaseModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
