using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriesa
{
    public class Dough
    {
        private const string InvalidDough= "Invalid type of dough.";
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType,string bakingTechnique,double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType 
        { 
            get 
            {
                return this.flourType;
            } 
            private set 
            {
                string valueToLower = value.ToLower();
                if (valueToLower!="white" && valueToLower!="wholegrain" )
                {
                    throw new ArgumentException(InvalidDough);
                }
                this.flourType = value;
            } 
        }
        public string BakingTechnique 
        { 
            get 
            {
                return this.bakingTechnique;
            } 
            private set 
            {
                string valueToLower = value.ToLower();
                if (valueToLower!= "crispy" && valueToLower!= "chewy" && valueToLower!= "homemade")
                {
                    throw new ArgumentException(InvalidDough);
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight 
        { 
            get 
            {
                return this.weight;
            } 
            private set 
            {
                if (value<MinWeight || value>MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                this.weight = value;
            } 
        }
        public double GetCalories()
        {
            double typeModifier = GetTypeModifier();
            double bakingModifier = GetBakingModifier();
            return 2 * this.Weight * typeModifier * bakingModifier;
        }

        private double GetBakingModifier()
        {
            string bakingToLower = this.BakingTechnique.ToLower();
            if (bakingToLower=="crispy")
            {
                return 0.9;
            }
            else if (bakingToLower=="chewy")
            {
                return 1.1;
            }
            return 1.0;
        }

        private double GetTypeModifier()
        {
            string typeToLower = this.FlourType.ToLower();
            if (typeToLower=="white")
            {
                return 1.5;
            }
            return 1.0;
        }
    }
}
