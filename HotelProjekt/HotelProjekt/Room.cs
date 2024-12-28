using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjekt
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        public bool IsAvailable;

        public decimal PricePerNight;

        public void MarkAsAvailable()
        {
            IsAvailable = true;
        }
        
        public void MarkAsOccupied()
        {
            IsAvailable = false;
        }
    }
}
