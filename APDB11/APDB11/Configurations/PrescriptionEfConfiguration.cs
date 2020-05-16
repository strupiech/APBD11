using APDB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APDB11.Configurations
{
    public class PrescriptionEfConfiguration: IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(p => p.IdPrescription);

            builder.Property(p => p.IdPrescription).ValueGeneratedOnAdd();

            builder.Property(p => p.Date).IsRequired();

            builder.Property(p => p.DueDate).IsRequired();

            builder.HasOne<Patient>()
                .WithMany()
                .HasForeignKey(p => p.IdPatient)
                .IsRequired();

            builder.HasOne<Doctor>()
                .WithMany()
                .HasForeignKey(p => p.IdDoctor)
                .IsRequired();
        }
    }
}