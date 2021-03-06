using Zad2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zad2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost()
        {
            (ViewData["Message"], ViewData["MessageClass"]) = FizzBuzz.getOutput();
            return Page();

        }
    }
}