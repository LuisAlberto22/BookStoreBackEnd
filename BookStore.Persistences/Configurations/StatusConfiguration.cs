using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using BookStore.Persistences.Configurations.BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	internal class StatusConfiguration : EntityTypeBaseConfiguration<Status>
	{

		protected override void ConfigurateTableName(EntityTypeBuilder<Status> builder)
		{
			builder.ToTable(nameof(Status) + "es");
		}
		protected override void ConfigurateConstrains(EntityTypeBuilder<Status> builder)
		{
			builder.HasIndex(x => x.Name).IsUnique();
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Status> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
		}
	}
}
