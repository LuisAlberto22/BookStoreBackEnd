using BookStore.Entities.BaseModels;

namespace BookStore.Entities
{
	public class Book : StatusableModel
	{
		public string Name { get; set; } = default!;
		public string Autor { get; set; } = default!;
		public string ISBN { get; set; } = default!;
		public int GenreId { get; set; } = default;
		public string ImageLink { get; set; } = default!;
		public Genre Genre { get; set; } = default!;
	}
}
