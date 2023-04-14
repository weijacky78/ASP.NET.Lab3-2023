using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment0.Models;

namespace Assignment0.Pages_Profile
{
    public class EditModel : PageModel
    {
        private readonly Assignment0.Models.Context _context;

        public EditModel(Assignment0.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public SiteUser SiteUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var siteuser =  await _context.Users.FirstOrDefaultAsync(m => m.SiteUserId == id);
            if (siteuser == null)
            {
                return NotFound();
            }
            SiteUser = siteuser;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SiteUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteUserExists(SiteUser.SiteUserId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SiteUserExists(uint id)
        {
          return (_context.Users?.Any(e => e.SiteUserId == id)).GetValueOrDefault();
        }
    }
}
