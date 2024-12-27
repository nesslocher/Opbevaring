using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejlighed
{
    public class ApartmentComplex
    {

        private string address;
        private List<Apartment> apartments = new List<Apartment>();

        //den forslog keyworded 'readonly' - spørg Søren

        public ApartmentComplex(string address)
        {
            this.address = address;
            this.apartments = new List<Apartment>();
        }

        public int GetNumberOfApartments() => apartments.Count;

        //returnerer totale nummer af lejligheder 
        // => arrow syntax (expression-bodied syntax) bruges som shortcut for {} return keyword

        public void Add(Apartment apartment)
        {
            //tilføjer en new lejlighed
            apartments.Add(apartment);
        }

        public Apartment GetApartment(int index)
        {
            return apartments[index];
        }

        public Apartment GetApartmentByNumber(int number)
        {
            return (Apartment)apartments[number];
        }


        //alternativ til GetApartmentByNumber = 
        //public Apartment GetApartmentByNumber(int number) { if (apartment.GetNumber == number) 
        //{ return apartment; } 
        //}return null;

        public Apartment GetApartmentByTenant(Tenant tenant)
        {
            //returner en lejlighed ud fra tenant
            return apartments.Find(apartments => apartments.Tenant == tenant);
        }

        public Apartment GetFirstAvailableApartment()
        {
            //find første ledige lejlighed
            return apartments.Find(apartment => apartment.IsAvailable());
        }

        public override string ToString()
        {
            return $"Apartment {address} with {GetNumberOfApartments()} apartments.";
        }

    }
}
