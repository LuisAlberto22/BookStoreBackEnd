namespace BookStore.Dtos.Requests.Customers
{
	public class StoreCustomerRequest
	{
		public string FirstName { get; set; } = default!;
		public string LastName { get; set; } = default!;
		public string DNI { get; set; } = default!;
		public byte Age { get; set; } = default!;
	}
}
