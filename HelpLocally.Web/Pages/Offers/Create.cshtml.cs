using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Offers
{
  public class CreateModel : PageModel
  {
    private readonly HelpLocallyContext _context;

    [BindProperty] public Offer Offer { get; set; }

    public ICollection<SelectListItem> OfferTypes { get; set; }
    public ICollection<SelectListItem> Companies { get; set; }

    public CreateModel(HelpLocallyContext context)
    {
      _context = context;
    }

    public async Task OnGetAsync()
    {
      OfferTypes = await _context.OfferTypes.Select(x => new SelectListItem(x.Name,
          x.Id.ToString()))
        .ToListAsync();
      Companies = await _context.Companies.Select(x => new SelectListItem(x.Name,
          x.Id.ToString()))
        .ToListAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
      await _context.Offers.AddAsync(Offer);
      await _context.SaveChangesAsync();
      return RedirectToPage("./Index");
    }
  }
}