namespace BookStore.Dtos.Responses.BaseResponses
{
	public abstract class BaseResponse
	{
		public string ErrorMessage { get; set; } = default!;
		public bool IsSuccess { get; set; } = false;
	}
}
