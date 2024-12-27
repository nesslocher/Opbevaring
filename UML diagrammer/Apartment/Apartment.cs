using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejlighed
{
    public class Apartment
    {
        private int number;
        public Tenant Tenant {  get; private set; } //property



        public Apartment(int number)
        {
            this.number = number;
            this.Tenant = null; //fordi lejligheden bliver skabt uden lejer
        }

        public int GetNumber()
        {
            return number;
        }
        //eller public int getNumber() => number;

        public bool IsAvailable()
        {
            return Tenant == null;
        }

        public void RentTo(Tenant tenant, MyDate RentedFrom)
        {
            if (IsAvailable())
            {
                this.Tenant = tenant;
                tenant.SetRentedFrom(RentedFrom);
            }
            else
            {
                throw new InvalidOperationException("apartment is rented");
            }


        }

        public Tenant GetTenant() => Tenant;

        public override string ToString()
        {
            return $"Apartment Number: {number}, Tenant: {Tenant?.ToString() ?? "Available"}";

        }
    }

}
