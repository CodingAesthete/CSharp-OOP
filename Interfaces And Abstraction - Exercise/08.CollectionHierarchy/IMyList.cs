using System;
using System.Collections.Generic;
using System.Text;

namespace CollHerra
{
    public interface IMyList<T>:IAddRemoveCollection<T> 
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
