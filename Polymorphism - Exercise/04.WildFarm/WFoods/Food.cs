using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarmIII.Foods
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
