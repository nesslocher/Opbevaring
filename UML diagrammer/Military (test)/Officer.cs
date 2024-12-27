using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public class Officer : Soldier
    {
        public int LeadershipValue { get ; private set; }

        public Officer(string name, int serialNo, string rank, int leadershipValue) : base(name, serialNo, rank)
        {
            LeadershipValue = leadershipValue;
        }

        public void AssignMission(Mission mission, Unit unit)
        {
            Console.WriteLine($"{Rank}");
        }
    }
}
