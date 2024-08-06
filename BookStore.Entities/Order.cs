namespace BookStore.Entities
{
	public class Order : StatusableModel
	{
        public DateTime MyProperty { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public List<Book> Books { get; set; } = default!;
    }
}
