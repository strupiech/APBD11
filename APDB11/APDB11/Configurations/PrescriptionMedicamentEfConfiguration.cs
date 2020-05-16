using APDB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APDB11.Configurations
{
    public class PrescriptionMedicamentEfConfiguration: IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(c => new {c.IdMedicament, c.IdPrescription});

            builder.HasOne<Medicament>()
                .WithMany()
                .HasForeignKey(p => p.IdMedicament)
                .IsRequired();

            builder.HasOne<Prescription>()
                .WithMany()
                .HasForeignKey(p => p.IdPrescription)
                .IsRequired();

            builder.Property(e => e.Dose).IsRequired();
        }
    }
}