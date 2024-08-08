using BookStore.Entities.Interfaces;

namespace BookStore.Entities
{
    public class Status : BaseModel
	{
		public string Name { get; set; } = default!;
		public List<Book> Books { get; set; }
		public List<Customer> Customers { get; set; }
		public List<Order> Orders { get; set; }
    }
}
