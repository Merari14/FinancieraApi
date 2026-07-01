using FinancieraApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancieraApi.Data
{
    public class FinancieraContext : DbContext
    {
        public  FinancieraContext(DbContextOptions<FinancieraContext> options)
            : base(options) 
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.IngresoMensual)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Prestamo>()
                .Property(p => p.TasaInteres)
                .HasPrecision(5, 2);
        }

    }
}
