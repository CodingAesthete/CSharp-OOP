using System;
using System.Collections.Generic;
using System.Text;

namespace CollHerra
{
    public interface IAddRemoveCollection<T>:IAddCollection<T>
    {
        T Remove();
    }
}
