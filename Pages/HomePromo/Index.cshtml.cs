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
    public class IndexModel : PageModel
    {
        private readonly homepromoContext _context;

        public IndexModel(homepromoContext context)
        {
            _context = context;
        }

        public IList<modelHomePromo> modelHomePromo { get;set; }

        public async Task OnGetAsync()
        {
            modelHomePromo = await _context.modelHomePromo.ToListAsync();
        }
    }
}
