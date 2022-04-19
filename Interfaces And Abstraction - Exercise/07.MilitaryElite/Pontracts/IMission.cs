using Military.Nums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void CompleteMission();
    }
}
