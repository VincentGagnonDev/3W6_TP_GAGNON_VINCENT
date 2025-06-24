using Microsoft.EntityFrameworkCore;
using JuliePro.Models;


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
        public DbSet<JuliePro.Models.Trainer> Trainer { get; set; } = default!;

        public DbSet<JuliePro.Models.Objective> Objectives { get; set; } = default!;

        public DbSet<JuliePro.Models.Customer> Customers { get; set; } = default!;
    }
}
