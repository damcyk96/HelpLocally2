using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Users
{
    public class Details : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty(SupportsGet = true)] public int Id { get; set; }

        [BindProperty] public User User { get; set; }

        public Details(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            User = await _context.Users
                .Include(x => x.Vouchers)
                .ThenInclude(x=>x.Offer)
                .ThenInclude(x=>x.Company)
                .FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}