using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjekt
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<Appointment> Appointments = new List<Appointment>();

        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }

        public List<Appointment> GetSchedule()
        {
            return Appointments;
        }

    }
}
