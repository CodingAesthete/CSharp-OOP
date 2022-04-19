using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string ex)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(ex);
            }
        }
        public static void ThrowIfMoneyIsNegative(decimal money, string ex)
        {
            if (money < 0)
            {
                throw new ArgumentException(ex);
            }

        }
    }
}
