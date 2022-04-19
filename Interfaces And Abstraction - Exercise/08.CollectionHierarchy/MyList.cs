using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollHerra
{
    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public IReadOnlyCollection<T> Used 
        { 
            get 
            {
                return Data as IReadOnlyCollection<T>;
            } 
        }
        public override T Remove()
        {
            T curr = Data.First();
            Data.RemoveAt(0);
            return curr;
        }
    }
}
