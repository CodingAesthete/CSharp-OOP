using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_PatternIII.Models
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return null;
        }
    }
}
