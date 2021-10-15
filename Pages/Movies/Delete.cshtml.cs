using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_Movies
{
    public class DeleteModel : PageModel
    {
        private readonly dotnet_NewProjectContext _context;

        public DeleteModel(dotnet_NewProjectContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            modelBaru = await _context.modelBaru.FindAsync(id);

            if (modelBaru != null)
            {
                _context.modelBaru.Remove(modelBaru);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
