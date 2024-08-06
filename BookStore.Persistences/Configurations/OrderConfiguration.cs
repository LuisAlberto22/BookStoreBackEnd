using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	internal class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			ConfigurateProperties(builder);
			ConfigurateConstrains(builder);
			ConfigurateTableName(builder);
		}
		protected void ConfigurateTableName(EntityTypeBuilder<Order> builder)
		{
			builder.ToTable(nameof(Order) + 's');
		}
		protected void ConfigurateConstrains(EntityTypeBuilder<Order> builder)
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

		protected void ConfigurateProperties(EntityTypeBuilder<Order> builder)
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
