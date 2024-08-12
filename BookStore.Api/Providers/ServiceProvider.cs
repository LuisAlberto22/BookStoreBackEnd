using BookStore.Services.Intefaces;
using BookStore.Services.Services;
using IServiceProvider = BookStore.Api.Providers.Interfaces.IServiceProvider;

namespace BookStore.Api.Providers
{
	public class ServiceProvider : IServiceProvider
	{
		public void Register(WebApplicationBuilder builder)
		{
			builder.Services.AddTransient<ICustomerService, CustomerService>();
		}
	}
}
