using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpLocally.Domain;
using HelpLocally.Infrastructure;
using HelpLocally.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HelpLocally.Web.Pages.Vouchers
{
    public class IndexModel : PageModel
    {
        private readonly HelpLocallyContext _context;
        private readonly IUserService _userService;
        public ICollection<Voucher> Vouchers { get; set; }

        public IndexModel(HelpLocallyContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task OnGetAsync()
        {
            var userId = _userService.GetUserId();
            Vouchers = await _context.Vouchers.Where(x => x.UserId == userId).ToArrayAsync();
        }
    }
}