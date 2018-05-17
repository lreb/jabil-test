namespace Jabil.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class JabilModel : DbContext
	{
		public JabilModel()
			: base("name=JabilConnectionString")
		{
		}

		public virtual DbSet<Building> Buildings { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<PartNumber> PartNumbers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Building>()
				.HasMany(e => e.Customers)
				.WithOptional(e => e.Building)
				.HasForeignKey(e => e.FKBuilding);

			modelBuilder.Entity<Building>()
				.HasMany(e => e.PartNumbers)
				.WithOptional(e => e.Building)
				.HasForeignKey(e => e.FKCustomer);
		}
	}
}
