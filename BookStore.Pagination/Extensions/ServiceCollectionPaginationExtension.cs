using BookStore.Pagination.Pagination;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Pagination.Extensions
{
	public static class ServiceCollectionPaginationExtension
	{
		public static void AddPaginator<TImplementation>(this IServiceCollection builder) where TImplementation : class, IPaginator
		{
			builder.AddSingleton<IPaginator, TImplementation>();
		}
	}
}
