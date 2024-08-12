using BookStore.Dtos.Responses.BaseResponses;

namespace BookStore.Dtos.Responses
{
	public class DataResponse<T> : BaseResponse
	{
		public T Body { get; set; }
	}
}
