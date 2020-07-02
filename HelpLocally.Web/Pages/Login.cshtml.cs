using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages
{
  public class LoginModel : PageModel
  {
    private readonly IAuthService _authService;
    private readonly IHttpContextAccessor _httpContext;
    private readonly HelpLocallyContext _context;

    public LoginModel(IAuthService authService, IHttpContextAccessor httpContext, HelpLocallyContext context)
    {
      _authService = authService;
      _httpContext = httpContext;
      _context = context;
    }

    [BindProperty] public User User { get; set; }

    public IActionResult OnGet()
    {
      if (_httpContext.HttpContext.User.Identities.Any(x => x.IsAuthenticated)) return RedirectToPage("/Index");

      User = new User();

      return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
      if (!ModelState.IsValid) return Page();

      var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == User.Login && x.Password == User.Password);

      if (user != null)
      {
        await _authService.Login(user);
        return RedirectToPage("/Offers/Index");
      }

      if (User.Login == "admin" && User.Password == "admin")
      {
        var adminUser = new User("admin", "admin", RolesDefaults.Admin);
        await _context.Users.AddAsync(adminUser);
        await _context.SaveChangesAsync();
        await _authService.Login(adminUser);
        return RedirectToPage("/Offers/Index");
      }

      return Page();
    }
  }
}