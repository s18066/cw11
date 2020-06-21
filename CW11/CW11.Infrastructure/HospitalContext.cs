using System;
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
    }
}