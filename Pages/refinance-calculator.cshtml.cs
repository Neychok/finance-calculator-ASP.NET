using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Finance_Calculator.Pages
{
    public class RefinanceModel : PageModel
    {
        private readonly ILogger<RefinanceModel> _logger;
        public string SavedHash { get; set; }

        public RefinanceModel(ILogger<RefinanceModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string savedHash)
        {
            SavedHash = savedHash;
        }
    }
}