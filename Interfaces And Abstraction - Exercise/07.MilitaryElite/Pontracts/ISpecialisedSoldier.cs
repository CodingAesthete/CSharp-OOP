using Military.Nums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
