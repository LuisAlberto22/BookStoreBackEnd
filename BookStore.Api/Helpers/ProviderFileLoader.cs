using IServiceProvider = BookStore.Api.Providers.IServiceProvider;

namespace BookStore.Api.Helpers
{
	internal static class ProviderFilesLoader
	{
		private static string ProviderDirectoryPath => Path.Combine(Directory.GetCurrentDirectory(), "Providers");
		public static IEnumerable<IServiceProvider> GetProviders()
		{
			if (!ProviderDirectoryExists())
				return Enumerable.Empty<IServiceProvider>();
			return GetServiceProviders();
		}

		private static bool ProviderDirectoryExists() => Directory.Exists(ProviderDirectoryPath);

		private static IEnumerable<IServiceProvider> GetServiceProviders()
		{
			var files = GetProviderFiles();
			return files.SelectMany(file => GetServiceProviderInstances(file)).ToList();
		}

		private static string[] GetProviderFiles() => Directory.GetFiles(ProviderDirectoryPath, "*.dll");

		private static IEnumerable<IServiceProvider> GetServiceProviderInstances(string file)
		{
			var types = AssemblyLoader.LoadTypesFromAssembly(file, typeof(IServiceProvider));
			return InstantiateServiceProviders(types).ToList();
		}

		private static IEnumerable<IServiceProvider> InstantiateServiceProviders(IEnumerable<Type> types)
		{
			foreach (var type in types)
			{
				yield return Activator.CreateInstance(type) as IServiceProvider;
			}
		}
	}
}
