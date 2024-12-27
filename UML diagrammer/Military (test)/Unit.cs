using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public class Unit
    {
        public string UnitName { get; set; }
        private List<Soldier> soldiers {  get; set; }

        public Unit(string unitName)
        {
            UnitName = unitName;
            soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier soldier)
        {
            soldiers.Add(soldier);
            Console.WriteLine( "soldat er tilføjet {Rank} og alt det der");
        }

        public void DeployToMission(Mission mission)
        {
            mission.StartMission();
        }


    }
}
