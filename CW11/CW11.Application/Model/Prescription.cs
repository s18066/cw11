using System;

namespace CW11.Application.Model
{
    public class Prescription
    {
        private Prescription()
        {
                
        }
        
        public Prescription(int idPrescription, DateTime date, DateTime dueDate, Patient patient, Doctor doctor)
        {
            IdPrescription = idPrescription;
            Date = date;
            DueDate = dueDate;
            Patient = patient;
            Doctor = doctor;
        }

        public int IdPrescription { get; private set; }
        
        public DateTime Date { get; private set; }

        public DateTime DueDate { get; private set; }
        
        public virtual Patient Patient { get; private set; }
        
        public virtual Doctor Doctor { get; private set; }
    }
}