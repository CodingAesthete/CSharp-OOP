using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Pontracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
        void Add(IPrivate @private);
    }
}
