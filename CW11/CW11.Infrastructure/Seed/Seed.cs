using System;
using CW11.Application.Model;
using Microsoft.EntityFrameworkCore;

namespace CW11.Infrastructure.Seed
{
    public static class Seed
    {
        public static void SeedDoctor(ModelBuilder builder)
        {
            builder.Entity<Doctor>().HasData(new
            {
                IdDoctor = -1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "mail@mail.com"
            });
            
            builder.Entity<Doctor>().HasData(new
            {
                IdDoctor = -2,
                FirstName = "Przemyslaw",
                LastName = "Zakala",
                Email = "p.zak@gmail.com"
            });
            
            builder.Entity<Doctor>().HasData(new
            {
                IdDoctor = -3,
                FirstName = "Jaroslaw",
                LastName = "Pulpet",
                Email = "pulpet@hotmail.com"
            });
        }
        
        public static void SeedPatient(ModelBuilder builder)
        {
            builder.Entity<Patient>().HasData(new
            {
                IdPatient = -1,
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = DateTime.Parse("2010-01-01")
            });
            
            builder.Entity<Patient>().HasData(new
            {
                IdPatient = -2,
                FirstName = "Bolek",
                LastName = "Dom",
                BirthDate = DateTime.Parse("2000-03-04")
            });
            
            builder.Entity<Patient>().HasData(new
            {
                IdPatient = -3,
                FirstName = "Lolek",
                LastName = "Cis",
                BirthDate = DateTime.Parse("1980-12-11")
            });
        }

        public static void SeedMedicament(ModelBuilder builder)
        {
            builder.Entity<Medicament>().HasData(new
            {
                IdMedicament = -1,
                Name = "wit. c",
                Description = " 100 mg",
                Type = "powlekane"
            });

            builder.Entity<Medicament>().HasData(new
            {
                IdMedicament = -2,
                Name = "wit. d",
                Description = " 1000 mg",
                Type = "kapsulka"
            });

            builder.Entity<Medicament>().HasData(new
            {
                IdMedicament = -3,
                Name = "metmin",
                Description = "steryd",
                Type = "aerozol"
            });
        }

        public static void SeedPrescription(ModelBuilder builder)
        {
            builder.Entity<Prescription>().HasData(new
            {
                IdPrescription = -1,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(2),
                PatientIdPatient = -1,
                DoctorIdDoctor = -1,
            });
            
            builder.Entity<Prescription>().HasData(new
            {
                IdPrescription = -2,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(2),
                PatientIdPatient = -1,
                DoctorIdDoctor = -2,
            });
            
            builder.Entity<Prescription>().HasData(new
            {
                IdPrescription = -3,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(4),
                PatientIdPatient = -3,
                DoctorIdDoctor = -1,
            });
        }
        
        public static void SeedPrescriptionMedicament(ModelBuilder builder)
        {
            builder.Entity<PrescriptionMedicament>().HasData(new
            {
                PrescriptionId = -2,
                MedicamentId = -1,
                Dose = 3,
                Details ="codziennie"
            });
            
            builder.Entity<PrescriptionMedicament>().HasData(new
            {
                PrescriptionId = -3,
                MedicamentId = -2,
                Dose = 4,
                Details ="dwa razy dziennie"
            });
            
            builder.Entity<PrescriptionMedicament>().HasData(new
            {
                PrescriptionId = -1,
                MedicamentId = -3,
                Details =""
            });
            
        }
    }
}