using CentroComercial.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentroComercial.API.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) : base(options) { }	

		public DbSet<Ejemplo>Ejemplos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Ejemplo>().HasIndex(c => c.FirstName).IsUnique();
		}
	}

}
