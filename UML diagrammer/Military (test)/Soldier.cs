using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public class Soldier
    {
        public string Name {  get; private set; }

        public string Rank { get; private set; }

        public int SerialNo { get; private set; }

        public Soldier(string name, int serialNo, string rank)
        {
            Name = name;
            SerialNo = serialNo;
            Rank = rank;

        }

        public void Report()
        {
            Console.WriteLine($"{Rank} {Name} is reporting for whatever");
        }
    }
}
