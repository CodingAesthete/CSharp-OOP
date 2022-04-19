using System;
using System.Collections.Generic;
using System.Text;

namespace Validation_AttributesIII.Attributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            string str = (string)obj;
            return !string.IsNullOrEmpty(str);
        }
    }
}
