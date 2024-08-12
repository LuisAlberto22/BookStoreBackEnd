using BookStore.Entities;
using BookStore.Persistences.Configurations.BaseConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	public class BookConfiguration : EntityTypeBaseConfiguration<Book>
	{
		protected override void ConfigurateTableName(EntityTypeBuilder<Book> builder)
		{
			builder.ToTable(nameof(Book) + 's');
		}

		protected override void ConfigurateConstrains(EntityTypeBuilder<Book> builder)
		{
			builder.HasIndex(x => x.ISBN).IsUnique();
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Book> builder)
		{
			builder.Property(x => x.ISBN).IsRequired().HasMaxLength(17);
			builder.Property(x => x.Autor).IsRequired().HasMaxLength(150);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(125);
			builder.Property(x => x.ImageLink).IsRequired().HasMaxLength(300);
			builder.Property(x => x.StatusId).IsRequired().HasDefaultValue(1);
		}

	}
}
