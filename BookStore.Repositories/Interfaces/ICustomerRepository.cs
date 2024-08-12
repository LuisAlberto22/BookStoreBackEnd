using BookStore.Dtos.Requests;
using BookStore.Entities;
using BookStore.Pagination.Configurations;
using BookStore.Pagination.Pagination;

namespace BookStore.Repositories.Interfaces
{
	public interface ICustomerRepository : IRepositoryBase<Customer>
	{
		Task<Pagination<Customer>> GetAllAsync(PaginationConfiguration paginationRequest);
	}
}
