using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjekt
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }

        public string Reason { get; set; }

        public void Reschedule(DateTime newDate)
        {
            Date = newDate;
        }
    }
}
