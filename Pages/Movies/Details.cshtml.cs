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
    public class DetailsModel : PageModel
    {
        private readonly dotnet_NewProjectContext _context;

        public DetailsModel(dotnet_NewProjectContext context)
        {
            _context = context;
        }

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
    }
}
