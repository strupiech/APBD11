using Microsoft.EntityFrameworkCore;

namespace APDB11.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicament> Prescription_Medicament { get; set; }


        public HospitalDbContext()
        {
        }

        public HospitalDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PrescriptionMedicament>()
                .HasKey(c => new {c.IdMedicament, c.IdPrescription});
        }
    }
}