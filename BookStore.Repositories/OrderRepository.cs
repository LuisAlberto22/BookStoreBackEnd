using BookStore.Entities;
using BookStore.Persistences;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(SQlDBContext context) : base(context)
		{
		}
	}
}
