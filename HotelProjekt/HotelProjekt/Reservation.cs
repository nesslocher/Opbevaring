using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjekt
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalCost { get; set; }

        public decimal CalculateTotalCost()
        {
            int nights = (CheckOutDate - CheckInDate).Days;
            TotalCost = nights * Room.PricePerNight;
            return TotalCost;
        }

        public void Cancel()
        {
            Room.MarkAsAvailable();
        }
    }
}
