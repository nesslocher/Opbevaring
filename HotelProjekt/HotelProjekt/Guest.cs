using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjekt
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Reservation> reservations = new List<Reservation>();

        public void MakeReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public List<Reservation> GetReservations()
        {
            return reservations;        
        }

    }
}
