using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HelpLocally.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HelpLocally.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult OnGet()
        {
            var userRole = _httpContextAccessor.HttpContext.User.Claims.Any();
        
            if (userRole)
            {
                if (User.IsInRole(RolesDefaults.Admin))
                {
                    return RedirectToPage("/Users/Index");
                }

                if (User.IsInRole(RolesDefaults.Seller))
                {
                    return RedirectToPage("/Offers/Index");
                }
            }

            return RedirectToPage("/Login");
        }
    }
}