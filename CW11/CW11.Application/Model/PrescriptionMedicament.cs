namespace CW11.Application.Model
{
    public class PrescriptionMedicament
    {
        public PrescriptionMedicament( int medicamentId, int prescriptionId, int? dose, string details)
        {
            MedicamentId = medicamentId;
            PrescriptionId = prescriptionId;
            Dose = dose;
            Details = details;
        }
        
        
        public virtual Medicament Medicament { get; private set; }
        
        public int MedicamentId { get; set; }
        
        public virtual Prescription Prescription { get; private set; }
        
        public int PrescriptionId { get; set; }
        
        public int? Dose { get; private set; }
        
        public string Details { get; private set; }
    }
}