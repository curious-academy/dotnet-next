using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.AI;

namespace TestRazorPlusAI.Pages
{
	public class IndexModel(IChatClient client) : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public async Task OnGet()
		{
			var response = await client.GetResponseAsync("What is AI?");
		}
	}
}
