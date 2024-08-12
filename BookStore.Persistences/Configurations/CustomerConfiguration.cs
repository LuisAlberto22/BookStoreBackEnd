using BookStore.Entities;
using BookStore.Persistences.Configurations.BaseConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	internal class CustomerConfiguration : EntityTypeBaseConfiguration<Customer>
	{
		protected override void ConfigurateTableName(EntityTypeBuilder<Customer> builder)
		{
			builder.ToTable(nameof(Customer) + 's');
		}
		protected override void ConfigurateConstrains(EntityTypeBuilder<Customer> builder)
		{
			builder.HasIndex(x => x.DNI).IsUnique();
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Customer> builder)
		{
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.DNI).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Age).IsRequired().HasMaxLength(8);
			builder.Property(x => x.StatusId).IsRequired().HasDefaultValue(1);
		}
	}
}
