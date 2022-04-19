using System;
using System.Collections.Generic;
using System.Text;
using WildFarmIII.Foods;

namespace WildFarmIII.Animals.Mammals.Felines
{
    public class Tiger:Feline
    {
        private const double BaseModifier = 1.00;
        private static HashSet<string> mouseAllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, mouseAllowedFoods, BaseModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
