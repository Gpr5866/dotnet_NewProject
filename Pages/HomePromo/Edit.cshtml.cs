using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_HomePromo
{
    public class EditModel : PageModel
    {
        private readonly homepromoContext _context;

        public EditModel(homepromoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public modelHomePromo modelHomePromo { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            modelHomePromo = await _context.modelHomePromo.FirstOrDefaultAsync(m => m.ID == id);

            if (modelHomePromo == null)
            {
                return NotFound();
            }
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

            _context.Attach(modelHomePromo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!modelHomePromoExists(modelHomePromo.ID))
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

        private bool modelHomePromoExists(string id)
        {
            return _context.modelHomePromo.Any(e => e.ID == id);
        }
    }
}
