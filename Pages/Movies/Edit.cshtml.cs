using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_Movies
{
    public class EditModel : PageModel
    {
        private readonly dotnet_NewProjectContext _context;

        public EditModel(dotnet_NewProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public modelBaru modelBaru { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            modelBaru = await _context.modelBaru.FirstOrDefaultAsync(m => m.ID == id);

            if (modelBaru == null)
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

            _context.Attach(modelBaru).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!modelBaruExists(modelBaru.ID))
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

        private bool modelBaruExists(int id)
        {
            return _context.modelBaru.Any(e => e.ID == id);
        }
    }
}
