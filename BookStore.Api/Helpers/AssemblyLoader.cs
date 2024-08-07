using System.Reflection;

namespace BookStore.Api.Helpers
{
	internal static class AssemblyLoader
	{
		public static IEnumerable<Type> LoadTypesFromAssembly(string file, Type baseType)
		{
			var assembly = Assembly.LoadFrom(file);
			return assembly.GetTypes()
						   .Where(t => baseType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);
		}
	}

}
