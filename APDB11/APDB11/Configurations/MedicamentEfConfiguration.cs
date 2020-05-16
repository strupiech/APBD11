using APDB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APDB11.Configurations
{
    public class MedicamentEfConfiguration: IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(m => m.IdMedicament);

            builder.Property(m => m.IdMedicament).ValueGeneratedOnAdd();

            builder.Property(m => m.Name).IsRequired();

            builder.Property(m => m.Description).IsRequired();

            builder.Property(m => m.Type).IsRequired();
        }
    }
}