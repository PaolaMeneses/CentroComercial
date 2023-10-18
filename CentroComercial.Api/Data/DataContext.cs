using CentroComercial.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentroComercial.API.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) : base(options) { }

        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<CComercial> Centrocomerciales { get; set; }

        public DbSet<Notificacion> Notificaciones { get; set; }

        public DbSet<Calendario> Calendario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CComercial>().HasIndex(c => c.IdCentroComercial).IsUnique();
            modelBuilder.Entity<Tienda>().HasIndex(c => c.IdTienda).IsUnique();
            modelBuilder.Entity<Notificacion>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Calendario>().HasIndex(c => c.Id).IsUnique();

        }
	}

}
