using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpLocally.Web.Pages.OfferTypes
{
    public class EditModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty(SupportsGet = true)] 
        public int Id { get; set; }

        [BindProperty] 
        public OfferType OfferType { get; set; }

        public EditModel(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            OfferType = await _context.OfferTypes.FindAsync(Id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var offerType = await _context.OfferTypes.FindAsync(OfferType.Id);
            offerType.Name = OfferType.Name;
            offerType.Description = OfferType.Description;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}