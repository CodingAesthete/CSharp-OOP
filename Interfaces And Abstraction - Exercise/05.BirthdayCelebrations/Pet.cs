using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
        public string Birthdate { get; private set; }
        public string Name { get; private set; }
    }
}
