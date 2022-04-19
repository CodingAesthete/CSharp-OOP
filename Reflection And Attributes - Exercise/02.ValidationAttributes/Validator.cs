using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Validation_AttributesIII.Attributes;

namespace Validation_AttributesIII
{
    public class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var prop in properties)
            {
                var res = prop.GetValue(obj);
                var attributes = prop.GetCustomAttributes().Cast<MyValidationAttribute>().ToArray();
                foreach (var att in attributes)
                {
                    if (!att.IsValid(res))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
