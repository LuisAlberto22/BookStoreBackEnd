using BookStore.Dtos.Requests;
using BookStore.Dtos.Requests.Customers;
using BookStore.Dtos.Responses;
using BookStore.Entities;
using BookStore.Pagination.Pagination;
using BookStore.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
	[ApiController]
	[Route("api/customers")]
	public class CustomerController : Controller
	{
		private readonly ICustomerService customerService;

		public CustomerController(ICustomerService customerService)
		{
			this.customerService = customerService;
		}

		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] PaginationRequest paginationRequest)
		{
			var response = new DataResponse<Pagination<Customer>>();
			try
			{
				response.Body = await customerService.GetAllAsync(paginationRequest);
				return Ok(response);
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return NotFound();
		}

		[HttpPost()]
		public async Task<IActionResult> Store([FromBody] StoreCustomerRequest request)
		{
			return NotFound();
		}

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Delete()
		{
			return NotFound();
		}

		[HttpPut("{id:int}")]
		public async Task<IActionResult> Update(int id, [FromBody] UpdateCustomerRequest request)
		{
			return NotFound();
		}
	}
}
