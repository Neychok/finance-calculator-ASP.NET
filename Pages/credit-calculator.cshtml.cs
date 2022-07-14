using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Finance_Calculator.Pages
{
    public class CreditModel : PageModel
    {
        private readonly ILogger<CreditModel> _logger;
        public string SavedHash { get; set; }

        [BindProperty]
        public int credit_amount { get; set; }

        public CreditModel(ILogger<CreditModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string savedHash)
        {
            SavedHash = savedHash;
            credit_amount = 0;
        }

        public void OnPost()
        {
            SavedHash = credit_amount.ToString();
        }

    }
}