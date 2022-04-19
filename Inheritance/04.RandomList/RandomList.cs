using System;
using System.Collections.Generic;
using System.Text;

namespace _04.RandomList
{
    public class RandomList : List<string>
    {
        private Random rand;
        public RandomList()
        {
            rand = new Random();
        }
        public string RandomString()
        {
            int index = rand.Next(0, this.Count);
            string curr = this[index];
            this.RemoveAt(index);
            return curr;
        }
    }
}

