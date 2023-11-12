using Microsoft.EntityFrameworkCore;
using Partial3_CiroOssaDanielFelipe.DAL.Entities;

namespace Partial3_CiroOssaDanielFelipe.DAL
{
    public class DataBaseContext : DbContext
    {
       

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.IDticket).IsUnique();
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
