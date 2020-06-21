namespace CW11.Application.Model
{
    public class Medicament
    {
        public Medicament(int idMedicament, string name, string description, string type)
        {
            IdMedicament = idMedicament;
            Name = name;
            Description = description;
            Type = type;
        }
        
        public int IdMedicament { get; private set; }
        
        public string Name { get; private set; }
        
        public string Description { get; private set; }
        
        public string Type { get; private set; }
    }
}