using System;

namespace CW11.Application.Model
{
    public class Prescription
    {
        public Prescription(int idPrescription, DateTime date, DateTime dueDate, int idPatient, int idDoctor)
        {
            IdPrescription = idPrescription;
            Date = date;
            DueDate = dueDate;
            IdPatient = idPatient;
            IdDoctor = idDoctor;
        }

        public int IdPrescription { get; private set; }
        
        public DateTime Date { get; private set; }

        public DateTime DueDate { get; private set; }
        
        public int IdPatient { get; private set; }
        
        public int IdDoctor { get; private set; }
    }
}