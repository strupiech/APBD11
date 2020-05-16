using APDB11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APDB11.Configurations
{
    public class DoctorEfConfiguration: IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.IdDoctor);

            builder.Property(d => d.IdDoctor).ValueGeneratedOnAdd();

            builder.Property(d => d.FirstName).IsRequired();

            builder.Property(d => d.LastName).IsRequired();
        }
    }
}