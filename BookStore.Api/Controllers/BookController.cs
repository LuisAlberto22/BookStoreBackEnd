using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
	[ApiController]
	[Route("api/books")]
	public class BookController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return NotFound();
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return NotFound();
		}

		[HttpPost()]
		public async Task<IActionResult> Store()
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
