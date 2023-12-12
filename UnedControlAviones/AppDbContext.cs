using UnedControlAviones.Models;
using Microsoft.EntityFrameworkCore;

namespace UnedControlAviones
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Avion> Avion { get; set; }
        public DbSet<Ingreso> Ingreso { get; set; }

        public DbSet<Despegue> Despegue { get; set; }

        public DbSet<Retiro> Retiro { get; set; }

    }
}
