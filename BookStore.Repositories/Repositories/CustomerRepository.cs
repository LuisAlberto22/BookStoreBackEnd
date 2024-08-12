using BookStore.Dtos.Requests;
using BookStore.Entities;
using BookStore.Pagination.Configurations;
using BookStore.Pagination.Pagination;
using BookStore.Persistences.DBContexts;
using BookStore.Repositories.BaseRepositories;
using BookStore.Repositories.Extensions;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories.Repositories
{
	public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
	{
		private readonly IPaginator _paginator;
		public CustomerRepository(SqlDbContext context, IPaginator paginator) : base(context)
		{
			_paginator = paginator;
		}

		public async Task<Pagination<Customer>> GetAllAsync(PaginationConfiguration paginationRequest)
		{
			return await DBSet.AsNoTracking().PaginateAsync(paginationRequest,_paginator);
		}
	}
}
