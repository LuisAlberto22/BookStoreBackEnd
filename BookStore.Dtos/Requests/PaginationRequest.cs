namespace BookStore.Dtos.Requests
{
	public class PaginationRequest
	{
		public int PerPage { get; set; } = 10;
		public int Page { get; set; } = 1;
	}
}
