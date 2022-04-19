using System;
using System.Collections.Generic;
using System.Text;

namespace Validation_AttributesIII.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            int num = (int)obj;
            return num >= minValue && num <= maxValue;
        }
    }
}
