using System;
using Autofac.Builder;
using CW11.Application.Model;
using Microsoft.EntityFrameworkCore;

namespace CW11.Infrastructure
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options): base(options)
        {
        }
        
        public virtual DbSet<Doctor> Doctors { get; set; }
        
        public virtual DbSet<Patient> Patients { get; set; }
        
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        
        public virtual DbSet<Medicament> Medicament { get; set; }
        
        public virtual DbSet<PrescriptionMedicament> PrescriptionMedicament { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasKey(x => x.IdDoctor);
            modelBuilder.Entity<Medicament>().HasKey(x => x.IdMedicament);
            modelBuilder.Entity<Prescription>().HasKey(x => x.IdPrescription);
            modelBuilder.Entity<PrescriptionMedicament>().HasKey(x => new {x.MedicamentId, x.PrescriptionId});
            modelBuilder.Entity<Patient>().HasKey(x => x.IdPatient);

            Seed.Seed.SeedDoctor(modelBuilder);
            Seed.Seed.SeedPatient(modelBuilder);
            Seed.Seed.SeedMedicament(modelBuilder);
            Seed.Seed.SeedPrescription(modelBuilder);
            Seed.Seed.SeedPrescriptionMedicament(modelBuilder);
        }
    }
}