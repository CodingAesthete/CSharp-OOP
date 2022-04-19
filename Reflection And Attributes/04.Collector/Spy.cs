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
        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType($"Stealer.{className}");
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo[] methods2 = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in methods.Where(p=>p.Name.StartsWith("get")))
            {
                sb.AppendLine($"{ method.Name} have to be public!");
            }
            foreach (var method in methods2.Where(p=>p.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
            return sb.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: { type.BaseType.Name}");
            foreach (var method in methods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().Trim();
        }
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var method in methods.Where(p=>p.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methods.Where(p=>p.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return sb.ToString().Trim();
        }
    }
}
