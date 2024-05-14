using Microsoft.EntityFrameworkCore;
using WebApplication13.Model;

namespace WebApplication13.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=\"Musical Instruments\";Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
