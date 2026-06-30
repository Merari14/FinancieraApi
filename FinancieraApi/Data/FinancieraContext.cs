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

    }
}
