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
    public class IndexModel : PageModel
    {
        private readonly dotnet_NewProjectContext _context;

        public IndexModel(dotnet_NewProjectContext context)
        {
            _context = context;
        }

        public IList<modelBaru> modelBaru { get;set; }

        public async Task OnGetAsync()
        {
            modelBaru = await _context.modelBaru.ToListAsync();
        }
    }
}
