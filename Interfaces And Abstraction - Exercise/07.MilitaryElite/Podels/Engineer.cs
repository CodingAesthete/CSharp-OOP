
using Military.Nums;
using Military.Podels;
using Military.Pontracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Podels
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs
        {
            get
            {
                return repairs.AsReadOnly();
            }
        }

        public void Add(IRepair repair)
        {
            repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");
            foreach (var item in repairs)
            {
                sb.AppendLine("  " + item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
