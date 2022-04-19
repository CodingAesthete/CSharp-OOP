using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        private string model;
        public StationaryPhone(string model)
        {
            this.model = model;
        }
        public string Call(string phone)
        {
            if (phone.All(s => char.IsDigit(s)))
            {
                return$"Dialing... {phone}";

            }
            else
            {
                return"Invalid number!";
            }
        }
    }
}
