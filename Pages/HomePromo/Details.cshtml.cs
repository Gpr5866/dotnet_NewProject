using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;

namespace dotnet_NewProject.Pages_HomePromo
{
    public class DetailsModel : PageModel
    {
        private readonly homepromoContext _context;

        public DetailsModel(homepromoContext context)
        {
            _context = context;
        }

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
    }
}
