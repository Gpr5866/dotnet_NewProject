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
            //generate ID
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var count = 0;
            foreach (var item in _context.modelHomePromo)
            {
                count++;
            }

            System.Console.WriteLine(count);
            int id = count + 1;
            string UniqueID = "P" + DateTime.Now.ToString("yyyyMMdd") + id.ToString("D4");
            System.Console.WriteLine(UniqueID);
            
            modelHomePromo m_bot_data = new modelHomePromo {
                ID = UniqueID,
                Description = modelHomePromo.Description,
                PromoType = modelHomePromo.PromoType,
                ValueType = modelHomePromo.ValueType,
                DurationStartDate = modelHomePromo.DurationStartDate,
                DurationEndDate = modelHomePromo.DurationEndDate,
                HasilFile = modelHomePromo.HasilFile,
                Store = modelHomePromo.Store,
                StoreName = modelHomePromo.StoreName,
            };


            _context.modelHomePromo.Add(m_bot_data);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
