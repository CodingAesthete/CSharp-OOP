using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}