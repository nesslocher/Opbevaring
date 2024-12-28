using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjekt
{
    public class Hospital
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public void RegisterDoctor(Doctor doctor)
        {
            Doctors.Add(doctor); 
        }
        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void ScheduleAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
            appointment.Doctor.AddAppointment(appointment);
            appointment.Patient.AddAppointment(appointment);
        }

        public List<MedicalRecord> GetMedicalRecords(Patient patient)
        {
            return patient.MedicalRecords;
        }

    }
}
