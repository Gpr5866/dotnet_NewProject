using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_HomePromo
{
    public class CreateModel : PageModel
    {
        private readonly homepromoContext _context;

        public CreateModel(homepromoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public modelHomePromo modelHomePromo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.modelHomePromo.Add(modelHomePromo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
