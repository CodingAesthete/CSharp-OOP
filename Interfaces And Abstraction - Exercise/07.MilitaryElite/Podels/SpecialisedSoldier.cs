
using Military.Nums;
using Military.Pontracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Podels
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; private set; }
    }
}
