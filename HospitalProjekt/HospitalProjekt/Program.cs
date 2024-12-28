namespace HospitalProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital
            {
                Name = "Silkeborg Hospital",
                Location = "Hospitalvej"
            };

            Doctor doctor = new Doctor
            {
                DoctorId = 1,
                Name = "Dr. Mark Lægemand",
                Specialization = "Cardiologi"
            };
            hospital.RegisterDoctor(doctor);
            
            Patient patient = new Patient
            {
                PatientId = 1,
                Name = "Martin Sygemand",
                Age = 32
            };
            hospital.RegisterPatient(patient);
            
            Appointment appointment = new Appointment
            {
                AppointmentId = 1,
                Doctor = doctor,
                Patient = patient,
                Date = DateTime.Now.AddDays(1),
                Reason = "Regulær sygebesøg hos Lægemand af Sygemand"
            };
            hospital.ScheduleAppointment(appointment);

            MedicalRecord record = new MedicalRecord
            {
                RecordId = 1,
                Patient = patient,
                Diagnosis = "Hypertension",
                Prescriptions = new List<string> { "Medicin A", "Medicin B" },
                Date = DateTime.Now
            };
            patient.MedicalRecords.Add(record);

            Console.WriteLine($"Hospital: {hospital.Name} at {hospital.Location}");
            Console.WriteLine($"Doctor: {doctor.Name}, Specialization: {doctor.Specialization}");
            Console.WriteLine($"Patient: {patient.Name}, Age: {patient.Age}");
            Console.WriteLine($"Appointment scheduled on: {appointment.Date}, Reason: {appointment.Reason}");
            Console.WriteLine($"Medical Record: {record.Diagnosis}, Prescriptions: {string.Join(", ", record.Prescriptions)}");
        }
    }
}
