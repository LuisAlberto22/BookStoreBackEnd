using BookStore.Dtos.Requests.Customers;
using BookStore.Pagination.Pagination;
using BookStore.Dtos.Requests;
using BookStore.Entities;

namespace BookStore.Services.Intefaces
{
	public interface ICustomerService
	{
		Task<Pagination<Customer>> GetAllAsync(PaginationRequest request);
		Task<Customer?> GetAsync(int id);
		Task<Customer> StoreAsync(StoreCustomerRequest customer);
		Task DeleteAsync(int id);
		Task UpdateAsync(int id, UpdateCustomerRequest customer);
	}
}
