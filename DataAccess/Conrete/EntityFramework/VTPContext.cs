using DataAccess.Concrete.EntityFramework.Mappers;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework
{
    public class VTPContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Event> Event { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\MSSQLLocalDB; Database = VTP; Trusted_connection = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParticipantMapper());
            modelBuilder.Entity<Participant>().Property(c => c.ParticipantId).ValueGeneratedNever();
        }
    }
}
