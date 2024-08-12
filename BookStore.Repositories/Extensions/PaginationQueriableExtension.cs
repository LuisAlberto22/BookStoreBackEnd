using BookStore.Pagination.Configurations;
using BookStore.Pagination.Pagination;

namespace BookStore.Repositories.Extensions
{
	public static class PaginationQueriableExtension
	{
		public async static Task<Pagination<T>> PaginateAsync<T>(this IQueryable<T> queryable, PaginationConfiguration paginationRequest, IPaginator paginator = null)
		{
			return await paginator.Paginate(queryable, paginationRequest);
		}
	}
}
