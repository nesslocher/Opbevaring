using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjekt
{
    public class MedicalRecord
    {
        public int RecordId { get; set; }
        public Patient Patient { get; set; }
        public string Diagnosis { get; set; }
        public List<string> Prescriptions { get; set; } = new List<string>();
        public DateTime Date { get; set; }

        public void UpdateRecord(string newDiagnosis, List<string> newPrescriptions)
        {
            Diagnosis = newDiagnosis;
            Prescriptions = newPrescriptions;
        }
    }
}
