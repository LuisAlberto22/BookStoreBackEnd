using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookStore.Persistences.Configurations.BaseConfigurations;

namespace BookStore.Persistences.Configurations
{
	public class GenreConfiguration : EntityTypeBaseConfiguration<Genre>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Genre> builder)
		{
			builder.HasIndex(x => x.Name).IsUnique();
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Genre> builder)
		{
			builder.Property(x => x.StatusId).IsRequired().HasDefaultValue(1);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Genre> builder)
		{
			builder.ToTable(nameof(Genre) + "s");
		}
	}
}
