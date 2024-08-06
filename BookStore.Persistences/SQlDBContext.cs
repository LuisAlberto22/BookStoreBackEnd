using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookStore.Persistences
{
	public class SQlDBContext : DbContext
	{
		public SQlDBContext(DbContextOptions options) : base(options) { }
	
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
