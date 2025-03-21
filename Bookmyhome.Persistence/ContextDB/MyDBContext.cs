
using Bookmyhome.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Configuration;

namespace Bookmyhome.Persistence.ContextDB
{
	public class MyDBContext : DbContext
	{

		public MyDBContext(DbContextOptions<MyDBContext> options)
		: base(options)
		{ }

		public DbSet<Bolig> BoligEF { get; set; }
		public DbSet<Bruger> BrugerEF { get; set; }
		public DbSet<Adresse> AdresseEF { get; set; }
		public DbSet<Anmeldelse> AnmeldelseEF { get; set; }
		public DbSet<Booking> BookingEF { get; set; }
		public DbSet<PostnummerOgBy> PostnummerOgByEF { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Bolig>().Property(e => e.Version).IsRowVersion();
			modelBuilder.Entity<Bruger>().Property(e => e.Version).IsRowVersion();
			modelBuilder.Entity<Adresse>().Property(e => e.Version).IsRowVersion();
			modelBuilder.Entity<Anmeldelse>().Property(e => e.Version).IsRowVersion();
			modelBuilder.Entity<Booking>().Property(e => e.Version).IsRowVersion();
			
		}
		

	}
}
