using ApiService;
using DbLibrary.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestPagesWeb.Pages
{
    public class IndexModel(GameService service) : PageModel
    {
        private readonly GameService _service = service;

        public IEnumerable<Game> Games { get; set; }

        public async Task OnGetAsync()
            => Games = await _service.GetGamesAsync();
    }
}
