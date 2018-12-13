using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.EntityConfiguration
{
    public class ProfessionConfiguration : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("VARCHAR(400)")
                .IsRequired();

            builder.Property(p => p.Code)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("VARCHAR(1000)")
                .IsRequired();
        }
    }
}