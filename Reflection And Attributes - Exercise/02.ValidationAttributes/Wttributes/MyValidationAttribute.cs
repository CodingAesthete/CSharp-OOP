using System;
using System.Collections.Generic;
using System.Text;

namespace Validation_AttributesIII.Attributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
