using ApiService;
using DbLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestPagesWeb.Pages.Shared
{
    public class DetailsModel(GameService service) : PageModel
    {
        private readonly GameService _service = service;

        [BindProperty]
        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Game = await _service.GetGamesByIdAsync(id);
            if (Game is null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateGameAsync(Game);
            return RedirectToPage("./Index");
        }
    }
}
