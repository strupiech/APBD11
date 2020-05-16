using System.Collections.Generic;
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
            
            var dictDoctors = new List<Doctor>();
            dictDoctors.Add(new Doctor()
            {
                IdDoctor = 1,
                FirstName = "Dominik",
                LastName = "Geniusz",
                Email = "geniusz@gmail.com"
            });
            
            dictDoctors.Add(new Doctor()
            {
                IdDoctor = 2,
                FirstName = "Mateusz",
                LastName = "GeniuszKwadrat",
                Email = "geniuszdokwadratu@gmail.com"
            });

            builder.HasData(dictDoctors);
        }
    }
}