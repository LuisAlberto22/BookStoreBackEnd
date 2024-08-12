using BookStore.Pagination.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Pagination.Pagination

{
	public class Paginator : IPaginator
	{
		public async Task<Pagination<T>> Paginate<T>(IQueryable<T> queryable, PaginationConfiguration configuration)
		{
			return new Pagination<T>()
			{
				Items = await queryable.Skip((configuration.Page - 1) * configuration.PerPage).Take(configuration.PerPage).ToListAsync(),
				PerPage = configuration.PerPage,
				Total = queryable.Count(),
				CurrentPage = configuration.Page,
				NextPage = ""
			};
		}
	}
}
