using BookStore.Entities;
using BookStore.Persistences;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
	{
		public CustomerRepository(SQlDBContext context) : base(context)
		{
		}
	}
}
