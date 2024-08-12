using Microsoft.Extensions.Logging;

namespace BookStore.Services.Intefaces
{
	internal interface IBaseService
	{
		void LogException(Exception ex, string message = "Ha ocurrido un error, intentalo mas tarde");
		T Map<T>(object value);
	}
}
