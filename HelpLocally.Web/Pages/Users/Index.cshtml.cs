using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly HelpLocallyContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ICollection<User> Users { get; set; }

        public IndexModel(HelpLocallyContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToArrayAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            
            int.TryParse(_httpContextAccessor.HttpContext.User.Claims
                .First(x => x.Type == ClaimTypes.NameIdentifier).Value, out id);

            if (user is {} && user.Id != id)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostResetPasswordAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            
            int.TryParse(_httpContextAccessor.HttpContext.User.Claims
                .First(x => x.Type == ClaimTypes.NameIdentifier).Value, out id);

            if (user is {} && user.Id != id)
            {
                user.Password = "12345678";
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}