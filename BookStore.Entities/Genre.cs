using BookStore.Entities.BaseModels;

namespace BookStore.Entities
{
	public class Genre : StatusableModel
	{
		public string Name { get; set; } = default!;
		public List<Book> books { get; set; } = default!;

	}
}
