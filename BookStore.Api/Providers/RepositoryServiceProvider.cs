
using BookStore.Repositories;
using BookStore.Repositories.Interfaces;

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
