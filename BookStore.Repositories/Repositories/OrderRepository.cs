using BookStore.Entities;
using BookStore.Persistences.DBContexts;
using BookStore.Repositories.BaseRepositories;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories.Repositories
{
	public class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(SqlDbContext context) : base(context)
		{
		}
	}
}
