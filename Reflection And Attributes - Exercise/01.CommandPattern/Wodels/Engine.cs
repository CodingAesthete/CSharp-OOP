using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_PatternIII.Models
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                string result = commandInterpreter.Read(command);
                if (result==null)
                {
                    break;
                }
                Console.WriteLine(result);
            }
            
        }
    }
}
