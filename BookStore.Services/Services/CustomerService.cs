using AutoMapper;
using BookStore.Dtos.Requests.Customers;
using BookStore.Dtos.Requests;
using BookStore.Entities;
using BookStore.Pagination.Configurations;
using BookStore.Pagination.Pagination;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Intefaces;
using BookStore.Services.Services.BaseServices;
using Microsoft.Extensions.Logging;

namespace BookStore.Services.Services
{
	public class CustomerService : BaseService, ICustomerService
	{
		private readonly ICustomerRepository customerRepository;

		public CustomerService(ICustomerRepository customerRepository, ILogger<CustomerService> logger,IMapper mapper) : base(logger, mapper)
		{
			this.customerRepository = customerRepository;
		}
		public async Task DeleteAsync(int id)
		{
			try
			{
				await customerRepository.DeleteAsync(id);
			}
			catch (Exception ex)
			{
				LogException(ex);
				throw;
			}
		}

		public async Task<Customer?> GetAsync(int id)
		{
			return await customerRepository.FindAsync(id);
		}

		public async Task<Pagination<Customer>> GetAllAsync(PaginationRequest paginationRequest)
		{
			var paginateConfiguration = Map<PaginationConfiguration>(paginationRequest);
			return await customerRepository.GetAllAsync(paginateConfiguration);
		}

		public async Task<Customer> StoreAsync(StoreCustomerRequest request)
		{
			try
			{
				return await SaveCustomerAsync(request);
			}
			catch (Exception ex)
			{
				LogException(ex);
				throw;
			}
		}

		private async Task<Customer> SaveCustomerAsync(StoreCustomerRequest request)
		{
			var customer = Map<Customer>(request);
			await customerRepository.AddAsync(customer);
			return customer;
		}

		public async Task UpdateAsync(int id, UpdateCustomerRequest request)
		{
			try
			{
				await UpdateCustomerAsync(request);
			}
			catch (Exception ex)
			{
				LogException(ex);
				throw;
			}
		}

		private async Task UpdateCustomerAsync(UpdateCustomerRequest request)
		{
			var customer = Map<Customer>(request);
			await customerRepository.UpdateAsync(1, customer);
		}
	}
}
