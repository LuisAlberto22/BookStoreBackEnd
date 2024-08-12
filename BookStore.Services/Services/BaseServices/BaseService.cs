using AutoMapper;
using BookStore.Services.Intefaces;
using Microsoft.Extensions.Logging;

namespace BookStore.Services.Services.BaseServices
{
	public abstract class BaseService : IBaseService
	{
		protected readonly ILogger<BaseService> logger;

		private readonly IMapper mapper;
		public BaseService(ILogger<BaseService> logger, IMapper mapper)
		{
			this.logger = logger;
			this.mapper = mapper;
		}

		public void LogException(Exception ex, string message = "Ha ocurrido un error, intentalo mas tarde")
		{
			logger.LogError(ex, message);
		}

		public T Map<T>(object value)
		{
			return mapper.Map<T>(value);
		}
	}
}
