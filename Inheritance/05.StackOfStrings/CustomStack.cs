using System;
using System.Collections.Generic;
using System.Text;

namespace _05.StackOfStrings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(Stack<string> stacko)
        {
            while (stacko.Count > 0)
            {
                this.Push(stacko.Pop());
            }
        }
    }
}

