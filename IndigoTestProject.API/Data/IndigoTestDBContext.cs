using IndigoTestProject.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IndigoTestProject.API.Data
{
    public class IndigoTestDBContext : DbContext
    {
        public IndigoTestDBContext(DbContextOptions<IndigoTestDBContext> options) : base(options) { }
        public DbSet<Products> Products => Set<Products>();
        public DbSet<Sales> Sales => Set<Sales>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=IndigoTestProjectDB.db");
            }
        }
    }
}
