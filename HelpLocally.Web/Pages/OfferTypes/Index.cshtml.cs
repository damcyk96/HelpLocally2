using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.OfferTypes
{
    public class IndexModel : PageModel
    {
        private readonly HelpLocallyContext _context;
        public ICollection<OfferType> OfferTypes { get; set; }

        public IndexModel(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            OfferTypes = await _context.OfferTypes.ToArrayAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var offerType = await _context.OfferTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (offerType is {})
            {
                _context.OfferTypes.Remove(offerType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}