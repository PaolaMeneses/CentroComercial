using CentroComercial.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentroComercial.API.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) : base(options) { }	

		public DbSet<CComercial>CentrosComerciales { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<CComercial>().HasIndex(c => c.IdCentroComercial).IsUnique();
            modelBuilder.Entity<Tienda>().HasIndex(c => c.IdTienda).IsUnique();
        }
	}

}
