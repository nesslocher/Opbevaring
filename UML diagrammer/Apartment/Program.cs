using System;
using System.Collections.Generic;
using System.Net;
using Lejlighed;

namespace Lejlighed
{
    public class Program
    {
      static void Main(string[] args)
        {
            ApartmentComplex complex = new ApartmentComplex("Silkeborg boligselskab"); //laver et 'complex'

            Console.WriteLine(complex.ToString()); //operater på vores 'complex' "caller"


            Apartment availableApartment = complex.GetFirstAvailableApartment();

        }
    }
}