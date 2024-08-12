namespace BookStore.Pagination.Pagination
{
	public class Pagination<T>
	{
		public int CurrentPage { get; set; }
		public int Total { get; set; }
		public int PerPage { get; set; }
		public string NextPage { get; set; } = default!;
		public List<T> Items { get; set; } = default!;
	}
}
