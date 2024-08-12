using AutoMapper;
using BookStore.Mappers.Profiles;
using IServiceProvider = BookStore.Api.Providers.Interfaces.IServiceProvider;

namespace BookStore.Api.Providers
{
	public class MapperServiceProvider : IServiceProvider
	{
		private List<Profile> profiles = new List<Profile>()
		{
			new CustomerMapper(),
			new PaginationMapper(),
		};
		public void Register(WebApplicationBuilder builder)
		{
			builder.Services.AddAutoMapper(config =>
			{
				config.AddProfiles(profiles);
			});
		}
	}
}
