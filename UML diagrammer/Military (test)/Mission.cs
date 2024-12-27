using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public class Mission
    {
        public string MissionName { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }

        public Mission(string missionName, string location, string status)
        {
            MissionName = missionName;
            Location = location;
            Status = status;
        }

        public void StartMission()
        {
            Status = "In progress";
        }

        public void CompleteMission()
        {
            Status = "Completed";
            Console.WriteLine($"Mission '{MissionName}' is completed");
        }
    }
}
