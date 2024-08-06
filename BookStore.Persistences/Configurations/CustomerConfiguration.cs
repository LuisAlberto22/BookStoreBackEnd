using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			ConfigurateConstrains(builder);
			ConfigurateProperties(builder);
			ConfigurateTableName(builder);
		}

		protected void ConfigurateTableName(EntityTypeBuilder<Customer> builder)
		{
			builder.ToTable(nameof(Customer) + 's');
		}
		protected void ConfigurateConstrains(EntityTypeBuilder<Customer> builder)
		{
			builder.HasIndex(x => x.DNI).IsUnique();
		}

		protected void ConfigurateProperties(EntityTypeBuilder<Customer> builder)
		{
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.DNI).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Age).IsRequired().HasMaxLength(8);
			builder.Property(x => x.StatusId).IsRequired().HasDefaultValue(1);
		}
	}
}
