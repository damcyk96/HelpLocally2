using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Common;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpLocally.Web.Pages
{
  public class Sign_UpModel : PageModel
  {
    private readonly HelpLocallyContext _context;

    [BindProperty]
    public User User { get; set; }
    public ICollection<SelectListItem> Roles { get; set; }
    private readonly IAuthService _authService;

    public Sign_UpModel(HelpLocallyContext context, IAuthService authService)
    {
      _context = context;
      _authService = authService;
    }
        
    public void OnGet()
    {
      Roles = RoleTypes.Roles.Where(x => x.Value !=  RolesDefaults.Admin).ToList();
    }

    public async Task<IActionResult> OnPostAsync()
    {
      await _context.Users.AddAsync(User);
      await _context.SaveChangesAsync();
      await _authService.Login(User);
      return RedirectToPage("./Index");
    }
  }
}