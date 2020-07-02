using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty(SupportsGet = true)] 
        public int Id { get; set; }

        [BindProperty] 
        public User User { get; set; }

        public ICollection<SelectListItem> Roles { get; set; }
        public ICollection<SelectListItem> Companies { get; set; }

        public EditModel(HelpLocallyContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            User = await _context.Users.FindAsync(Id);
            Roles = RoleTypes.Roles;
            Companies = (await _context.Companies.ToListAsync()).Select(x => new SelectListItem(x.Name,
                    x.Id.ToString()))
                .ToList();
        }

        public async Task OnPostAsync()
        {
            var user = await _context.Users.FindAsync(User.Id);
            user.Role = User.Role;
            user.CompanyId = User.CompanyId;
            await _context.SaveChangesAsync();
        }
    }
}