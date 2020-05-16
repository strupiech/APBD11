using APDB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APDB11.Configurations
{
    public class PatientEfConfiguration: IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.IdPatient);

            builder.Property(p => p.IdPatient).ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName).IsRequired();

            builder.Property(p => p.LastName).IsRequired();
        }
    }
}