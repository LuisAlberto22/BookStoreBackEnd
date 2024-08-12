using BookStore.Api.Providers.Interfaces;


namespace BookStore.Api.Providers.Registers
{
	internal class ServiceProviderRegister : IServiceProviderRegister
	{

		private List<Interfaces.IServiceProvider> _services = new List<Interfaces.IServiceProvider>()
		{
			new DBContextServiceProvider(),
			new RepositoryServiceProvider(),
			new ServiceProvider(),
			new MapperServiceProvider(),
		};

		/// <summary>
		/// Registra los Provedores de servicios
		/// </summary>
		/// <param name="builder"></param>
		public void RegisterProviders(WebApplicationBuilder builder)
		{
			foreach (var service in _services)
			{
				service.Register(builder);
			}
		}
	}
}
