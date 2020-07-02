using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpLocally.Web.Pages.Vouchers
{
    public class CreateModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty]
        public Company Company { get; set; }

        public CreateModel(HelpLocallyContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _context.Companies.AddAsync(Company);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}