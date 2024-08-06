using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BookStore.Persistences.Configurations
{
	internal class StatusConfiguration : IEntityTypeConfiguration<Status>
	{
		public void Configure(EntityTypeBuilder<Status> builder)
		{
			ConfigurateProperties(builder);
			ConfigurateConstrains(builder);
			ConfigurateTableName(builder);
		}

		protected void ConfigurateTableName(EntityTypeBuilder<Status> builder)
		{
			builder.ToTable(nameof(Status) + "es");
		}
		protected void ConfigurateConstrains(EntityTypeBuilder<Status> builder)
		{
			builder.HasIndex(x => x.Name).IsUnique();
		}

		protected void ConfigurateProperties(EntityTypeBuilder<Status> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
		}
	}
}
