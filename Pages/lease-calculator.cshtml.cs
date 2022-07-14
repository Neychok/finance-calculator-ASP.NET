using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Finance_Calculator.Pages
{
    public class LeaseModel : PageModel
    {
        private readonly ILogger<LeaseModel> _logger;
        public string SavedHash { get; set; }

        public LeaseModel(ILogger<LeaseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string savedHash)
        {
            SavedHash = savedHash;
        }
    }
}