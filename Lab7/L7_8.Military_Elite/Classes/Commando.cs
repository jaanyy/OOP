using System;
using System.Collections.Generic;
using System.Text;

namespace L7_8.Military_Elite.Classes
{
    class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<Mission>();
        }

        public List<IMission> Missions
        {
            get
            {
                return this.missions;
            }
        }

        public void AddMission(Mission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Missions:");

            this.missions
                .ForEach(m => builder.AppendLine(m.ToString()));

            return builder.ToString().TrimEnd();
        }
    }
}
