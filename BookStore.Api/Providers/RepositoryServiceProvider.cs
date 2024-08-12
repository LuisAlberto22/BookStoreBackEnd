
using BookStore.Repositories.Interfaces;
using BookStore.Repositories.Repositories;
using IServiceProvider = BookStore.Api.Providers.Interfaces.IServiceProvider;

namespace BookStore.Api.Providers
{
	public class RepositoryServiceProvider : IServiceProvider
	{
		public void Register(WebApplicationBuilder builder)
		{
			builder.Services.AddTransient<IBookRepository, BookRepository>();
			builder.Services.AddTransient<IOrderRepository, OrderRepository>();
			builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
			builder.Services.AddTransient<IStatusRepository, StatusRepository>();
		}
	}
}
