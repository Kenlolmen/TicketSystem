using Microsoft.EntityFrameworkCore;
using TicketSystem.src.TicketSystem.Core.Entities;

namespace TicketSystem.src.TicketSystem.Infrastructure.DAL
{
    public class TicketSystemDbContext : DbContext
    {
        public TicketSystemDbContext(DbContextOptions<TicketSystemDbContext> options) : base(options)
        {
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}