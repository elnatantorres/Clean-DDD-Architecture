using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.EntityConfiguration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            
            builder.Property(e => e.Name)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(e => e.PhoneNumber)
                .HasColumnType("VARCHAR(15)");
        }
    }
}