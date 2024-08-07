using BookStore.Api.Helpers;

namespace BookStore.Api.Providers
{
    internal class ServiceProviderRegister : IServiceProviderRegister
	{
		/// <summary>
		/// Registra los Provedores de servicios en la carpeta Providers
		/// </summary>
		/// <param name="builder"></param>
		public void RegisterProviders(WebApplicationBuilder builder)
		{
			var providers = ProviderFilesLoader.GetProviders();
			foreach (var provider in providers) 
			{
				provider.Register(builder);
			}
		}
	}
}
