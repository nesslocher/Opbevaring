using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjekt
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }

        public List<Room> Rooms = new List<Room>();

        public List<Reservation> Reservations = new List<Reservation>();    

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void MakeReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
            reservation.Room.MarkAsOccupied();
        }

        public void CancelReservation(int reservationId) //r => r.ReservationId = reservationId er et lamda udtryk
        {              //for hver Reservation objekt (r) i listen tjekker den "r.reservation" efter det objekt der passer til "==reservationId"
            var reservation = Reservations.Find(r => r.ReservationId == reservationId);
            if (reservation != null) //eller (reservation.ReservationId == reservationId)
            {
                reservation.Room.MarkAsOccupied();
                Reservations.Remove(reservation);
            }
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            return Rooms.FindAll(r => r.IsAvailable);
        }
    }
}
