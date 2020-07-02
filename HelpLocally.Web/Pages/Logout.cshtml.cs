using System.Threading.Tasks;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpLocally.Web.Pages
{
  public class Logout : PageModel
  {
    private readonly IAuthService _authService;

    public Logout(IAuthService authService)
    {
      _authService = authService;
    }

    public async Task<RedirectToPageResult> OnGet()
    {
      await _authService.Logout();
      return RedirectToPage("/Login");
    }
  }
}