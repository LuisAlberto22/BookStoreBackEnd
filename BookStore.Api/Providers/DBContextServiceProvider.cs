using BookStore.Persistences.DBContexts;
using Microsoft.EntityFrameworkCore;
using IServiceProvider = BookStore.Api.Providers.Interfaces.IServiceProvider;

namespace BookStore.Api.Providers
{
	internal class DBContextServiceProvider : IServiceProvider
	{
		public void Register(WebApplicationBuilder builder)
		{
			builder.Services.AddDbContext<SqlDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
			});
		}
	}
}
