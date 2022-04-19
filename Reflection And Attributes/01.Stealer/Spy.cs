using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className,params string [] fieldNames)
        {
            Type type = Type.GetType(className);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {className}");
            object curr = Activator.CreateInstance(type);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);
            var filetered = fields.Where(p => fieldNames.Contains(p.Name));
            foreach (var field in filetered)
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(curr)}");
            }
            return sb.ToString().Trim();
        }
    }
}
