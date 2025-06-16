using Microsoft.EntityFrameworkCore;


namespace JuliePro.Models.Data
{
    public class JulieProDbContext : DbContext
    {

        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.GenerateData();
        }

        public DbSet<Speciality> Specialities { get; set; }
    }
}
