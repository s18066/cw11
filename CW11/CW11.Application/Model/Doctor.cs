namespace CW11.Application.Model
{
    public class Doctor
    {
        private Doctor(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        
        private Doctor(int idDoctor, string firstName, string lastName, string email)
        {
            IdDoctor = idDoctor;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        
        public int IdDoctor { get; private set; }
        
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }
        
        public string Email { get; private set; }

        public void Modify(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public static Doctor Create(string firstName, string lastName, string email) => new Doctor(firstName, lastName, email);
    }
}