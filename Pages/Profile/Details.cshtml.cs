using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment0.Models;

namespace Assignment0.Pages_Profile
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment0.Models.Context _context;

        public DetailsModel(Assignment0.Models.Context context)
        {
            _context = context;
        }

        public SiteUser SiteUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            int? id = 1;
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var siteuser = await _context.Users.FirstOrDefaultAsync(m => m.SiteUserId == id);
            if (siteuser == null)
            {
                return NotFound();
            }
            else
            {
                SiteUser = siteuser;
            }
            return Page();
        }
    }
}
