using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Offers
{
  public class IndexModel : PageModel
  {
    private readonly HelpLocallyContext _context;
    private readonly IUserService _userService;
    public ICollection<Offer> Offers { get; set; }

    public IndexModel(HelpLocallyContext context, IUserService userService)
    {
      _context = context;
      _userService = userService;
    }

    public async Task OnGetAsync()
    {
      Offers = await _context.Offers
        .Include(x => x.Company)
        .Include(x => x.OfferType)
        .ToArrayAsync();
    }

    public async Task<RedirectToPageResult> OnPostAsync(int id)
    {
      var offer = await _context.Offers.FindAsync(id);
      offer.IsDeleted = true;
      
      var userId = _userService.GetUserId();
      var user = await _context.Users.FindAsync(id);
      
      var voucher = new Voucher(offer, offer.Id, user, userId, offer.Price, offer.Price, DateTime.Now.AddDays(128));
      
      await _context.Vouchers.AddAsync(voucher);

      await _context.SaveChangesAsync();
      return RedirectToPage("/Vouchers/Index");
    }
  }
}