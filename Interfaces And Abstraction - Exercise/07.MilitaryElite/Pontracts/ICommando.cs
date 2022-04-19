using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
        void Add(IMission mission);
    }
}
