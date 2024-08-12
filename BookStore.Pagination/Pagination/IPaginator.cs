using BookStore.Pagination.Configurations;

namespace BookStore.Pagination.Pagination
{
	public interface IPaginator
	{
		Task<Pagination<T>> Paginate<T>(IQueryable<T> queryable, PaginationConfiguration configuration);
	}
}