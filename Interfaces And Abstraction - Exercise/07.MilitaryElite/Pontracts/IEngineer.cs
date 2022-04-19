using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
        void Add(IRepair repair);
    }
}
