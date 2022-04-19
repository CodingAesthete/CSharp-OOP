
using Military.Nums;
using Military.Pontracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Podels
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions
        {
            get
            {
                return missions.AsReadOnly();
            }
        }

        public void Add(IMission mission)
        {
            missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            foreach (var item in missions)
            {
                sb.AppendLine("  " + item);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
