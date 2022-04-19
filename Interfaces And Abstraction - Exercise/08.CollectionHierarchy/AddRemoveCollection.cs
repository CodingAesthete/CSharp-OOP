using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollHerra
{
    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private const int start = 0;
        public virtual T Remove()
        {
            T curr = Data.Last();
            Data.RemoveAt(Data.Count - 1);
            return curr;
        }
        public override int Add(T element)
        {
            Data.Insert(start, element);
            return start;
        }
    }
}
