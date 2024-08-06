namespace BookStore.Entities
{
	public class Customer : StatusableModel
	{
		public string FirstName { get; set; } = default!;
		public string LastName { get; set; } = default!;
		public string DNI { get; set; } = default!;
		public byte Age { get; set; } = default!;
		List<Order> Orders { get; set; } = default!;
	}
}
