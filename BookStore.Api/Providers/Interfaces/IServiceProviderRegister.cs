namespace BookStore.Api.Providers.Interfaces
{
	internal interface IServiceProviderRegister
	{
		/// <summary>
		/// Registra los provedores de servicios de la carpeta Providers
		/// </summary>
		/// <param name="builder"></param>
		void RegisterProviders(WebApplicationBuilder builder);
	}
}