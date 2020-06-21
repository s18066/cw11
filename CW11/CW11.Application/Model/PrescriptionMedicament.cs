namespace CW11.Application.Model
{
    public class PrescriptionMedicament
    {
        public PrescriptionMedicament(int idMedicament, int idPrescription, int? dose, string details)
        {
            IdMedicament = idMedicament;
            IdPrescription = idPrescription;
            Dose = dose;
            Details = details;
        }
        
        public int IdMedicament { get; private set; }
        
        public int IdPrescription { get; private set; }
        
        public int? Dose { get; private set; }
        
        public string Details { get; private set; }
    }
}