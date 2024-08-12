using BookStore.Pagination.Pagination;
using BookStore.Services.Intefaces;
using BookStore.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Services.Extensions
{
	public static class ServiceCollectionServiceExtension
	{
		public static void AddServices(this IServiceCollection IServiceCollection)
		{
			IServiceCollection.AddTransient<ICustomerService, CustomerService>();
		}
	}
}
