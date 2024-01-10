using System;

namespace Project.Models
{
    public class Patient
    {
        public PatientInfo patientInfo;

        public List<Medication> medList;
        public Patient()
        {
            Console.WriteLine(medList[0]);
        }
    }
}