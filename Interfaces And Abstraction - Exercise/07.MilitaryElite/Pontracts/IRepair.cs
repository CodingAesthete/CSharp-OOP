using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
