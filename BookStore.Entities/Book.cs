namespace BookStore.Entities
{
	public class Book : StatusableModel
	{
		public string Name { get; set; } = default!;
		public string Autor { get; set; } = default!;
		public string ISBN { get; set; } = default!;
		public string State { get; set; } = default!;
    }
}
