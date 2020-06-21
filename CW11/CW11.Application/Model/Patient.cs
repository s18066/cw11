using System;

namespace CW11.Application.Model
{
    public class Patient
    {
        public Patient(int idPatient, string firstName, string lastName, DateTime birthDate)
        {
            IdPatient = idPatient;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        
        public int IdPatient { get; private set; }
        
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }
        
        public DateTime BirthDate { get; private set; }
    }
}