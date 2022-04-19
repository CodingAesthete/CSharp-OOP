using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Validator
    {
        public static void ThrowInvalidNameException(string value, string exception)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(exception);
            }
        }
        public static void ThrowInvalidStatsException(int value,int min, int max, string exception)
        {
            if (value<min || value>max)
            {
                throw new ArgumentException(exception);
            }
        }
    }
}
