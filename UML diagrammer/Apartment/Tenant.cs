using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lejlighed;

namespace Lejlighed
{
    public class Tenant
    {
        private string name = string.Empty;
        private MyDate rentedFrom = new MyDate();


        public Tenant(string name)
        {
            this.name = name;
            this.rentedFrom = null;
        }

        public string GetName() => name;

        public MyDate GetRentedFrom() //return type er MyDate
        {
            return rentedFrom;
        }

        public void SetRentedFrom(MyDate date)
        {
            this.rentedFrom = date;
        }

        public bool Equals(object obj)
        {
            if (obj is Tenant other)
            {
                return this.name == other.name;
            }
            return false;
        }
    }
}
