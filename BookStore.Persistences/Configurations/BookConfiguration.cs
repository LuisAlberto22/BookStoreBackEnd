using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistences.Configurations
{
	internal class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			ConfigurateProperties(builder);
			ConfigurateConstraints(builder);
			ConfigurateTableName(builder);
		}

		private void ConfigurateTableName(EntityTypeBuilder<Book> builder)
		{
			builder.ToTable(nameof(Book) + 's');
		}

		private void ConfigurateConstraints(EntityTypeBuilder<Book> builder)
		{
			builder.HasIndex(x => x.ISBN).IsUnique();
		}

		private void ConfigurateProperties(EntityTypeBuilder<Book> builder)
		{
			builder.Property(x => x.ISBN).IsRequired().HasMaxLength(17);
			builder.Property(x => x.Autor).IsRequired().HasMaxLength(150);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(125);
			builder.Property(x => x.StatusId).IsRequired().HasDefaultValue(1);
		}
	}
}
