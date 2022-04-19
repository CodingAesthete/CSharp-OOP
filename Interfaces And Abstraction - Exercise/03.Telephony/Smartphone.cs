using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        private string model;

        public Smartphone(string model)
        {
            this.model = model;
        }

        public string Browse(string website)
        {

            bool hasDigit = website.Any(char.IsDigit);
            if (hasDigit)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Invalid URL!");
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Browsing: {website}!");
                return sb.ToString();
            }
        }
        public string Call(string phone)
        {
            bool hasCharacter = phone.Any(char.IsLetter);
            if (hasCharacter)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Invalid number!");
                return sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Calling... {phone}");
                return sb.ToString();
            }
        }
    }
}
