using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty(SupportsGet = true)] 
        public int Id { get; set; }

        [BindProperty] 
        public ICollection<Offer> Offers { get; set; }

        public DetailsModel(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Offers = await _context.Offers
                .Include(x=>x.OfferType)
                .Include(x=>x.Company)
                .Where(x=>x.CompanyId == Id)
                .ToListAsync();
        }
    }
}