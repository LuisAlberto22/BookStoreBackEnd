using BookStore.Entities;
using BookStore.Persistences.Configurations.BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistences.Configurations
{
	internal class OrderConfiguration : EntityTypeBaseConfiguration<Order>
	{
		protected override void ConfigurateTableName(EntityTypeBuilder<Order> builder)
		{
			builder.ToTable(nameof(Order) + 's');
		}
		protected override void ConfigurateConstrains(EntityTypeBuilder<Order> builder)
		{
			builder.HasOne(o => o.Customer)
					.WithMany(c => c.Orders)
					.HasForeignKey(o => o.CustomerId)
					.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(o => o.Status)
				.WithMany(s => s.Orders)
				.HasForeignKey(o => o.StatusId)
				.OnDelete(DeleteBehavior.NoAction);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Order> builder)
		{
			builder.Property(x => x.Date)
				.IsRequired()
				.HasColumnType("date")
				.HasDefaultValueSql("GETDATE()");

			builder.Property(x => x.CustomerId)
				.IsRequired();

			builder.Property(x => x.StatusId)
				.IsRequired()
				.HasDefaultValue(1);
		}
	}
}
