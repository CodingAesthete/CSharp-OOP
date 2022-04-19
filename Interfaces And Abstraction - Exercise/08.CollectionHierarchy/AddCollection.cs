using System;
using System.Collections.Generic;
using System.Text;

namespace CollHerra
{
    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            Data = new List<T>();
        }
        protected List<T> Data { get; set; }
        public virtual int Add(T element)
        {
            Data.Add(element);
            return Data.Count - 1;
        }
    }
}
