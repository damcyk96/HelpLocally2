using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpLocally.Web.Pages.Vouchers
{
    public class EditModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty(SupportsGet = true)] 
        public int Id { get; set; }

        [BindProperty] 
        public Voucher Voucher { get; set; }
        

        public EditModel(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Voucher = await _context.Vouchers.FindAsync(Id);
        }

        public async Task OnPostAsync()
        {
            var voucher = await _context.Companies.FindAsync(Voucher.Id);
            // voucher.Name = Domain.Voucher.Name;
            await _context.SaveChangesAsync();
        }
    }
}