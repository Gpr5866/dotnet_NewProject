using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_Movies
{
    public class CreateModel : PageModel
    {
        private readonly dotnet_NewProjectContext _context;

        public CreateModel(dotnet_NewProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public modelBaru modelBaru { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.modelBaru.Add(modelBaru);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
