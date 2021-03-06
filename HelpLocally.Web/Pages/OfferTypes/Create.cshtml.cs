using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpLocally.Web.Pages.OfferTypes
{
    public class CreateModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty]
        public OfferType OfferType { get; set; }

        public CreateModel(HelpLocallyContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _context.OfferTypes.AddAsync(OfferType);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}