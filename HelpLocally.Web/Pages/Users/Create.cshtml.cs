using System.Collections.Generic;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpLocally.Web.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly HelpLocallyContext _context;

        [BindProperty]
        public User User { get; set; }
        public ICollection<SelectListItem> Roles { get; set; }

        public CreateModel(HelpLocallyContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            Roles = RoleTypes.Roles;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            User.Password = "12345678";
            await _context.Users.AddAsync(User);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}