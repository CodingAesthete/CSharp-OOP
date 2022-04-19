using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Command_PatternIII.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();
            string name = tokens[0];
            string[] comArgs = tokens.Skip(1).ToArray();
            var type = Assembly.GetCallingAssembly().GetTypes().Where(s => s.Name == $"{name}Command").FirstOrDefault();
            var inst = (ICommand)Activator.CreateInstance(type);
            var result = inst.Execute(comArgs);
            return result;
        }
    }
}
