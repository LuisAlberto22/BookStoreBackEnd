using BookStore.Persistences;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Providers
{
	internal class DBContextServiceProvider : IServiceProvider
	{
		public void Register(WebApplicationBuilder builder)
		{
			builder.Services.AddDbContext<SQlDBContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
			});
		}
	}
}
