using System;

namespace CW11.Application.Model
{
    public class Patient
    {
        public Patient(int idDoctor, string firstName, string lastName, DateTime birthDate)
        {
            IdDoctor = idDoctor;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        
        public int IdDoctor { get; private set; }
        
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }
        
        public DateTime BirthDate { get; private set; }
    }
}