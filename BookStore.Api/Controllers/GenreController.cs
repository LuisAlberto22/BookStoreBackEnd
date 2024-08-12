using BookStore.Dtos.Requests.Customers;
using BookStore.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
	[ApiController]
	[Route("api/genres")]
	public class GenreController : Controller
	{
		private readonly ICustomerService customerService;

		public GenreController(ICustomerService customerService)
		{
			this.customerService = customerService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				return Ok();
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
		public async Task<IActionResult> Update()
		{
			return NotFound();
		}
	}
}
