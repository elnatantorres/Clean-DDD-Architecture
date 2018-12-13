using Microsoft.EntityFrameworkCore;
using CMS.ApplicationCore.Entity;
using CMS.Infrastructure.EntityConfiguration;

namespace CMS.Infrastructure.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Profession> Professions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Profession>().ToTable("Profession");

            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessionConfiguration());
        }
    }
}