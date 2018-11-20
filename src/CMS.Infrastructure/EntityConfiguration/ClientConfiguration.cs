using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.EntityConfiguration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(e => e.Name)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
            
            builder.Property(e => e.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();
        }
    }
}