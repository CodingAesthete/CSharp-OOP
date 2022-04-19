using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
