using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookStore.Persistences.DBContexts
{
	public class SqlDbContext : DbContext
	{
		public SqlDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
