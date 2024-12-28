using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjekt
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public List<MedicalRecord> ViewMedicalRecs()
        {
            return MedicalRecords;
        }

        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }


    }
}
