using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnet_NewProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        // [HttpPost("insert")]
        // public ActionResult<IEnumerable<string>> Create ([FromBody]modelBaru modelbaru) {
        //     using (var transaction = _context.Database.BeginTransaction()) {
        //         try
        //         {
        //             modelBaru m_bot_data = new modelBaru
        //             {
        //                 Judul = modelbaru.Judul,
        //                 ReleaseDate = modelbaru.ReleaseDate,
        //                 Genre = modelbaru.Genre,
        //                 Price = modelbaru.Price
        //             };

        //             _context.modelBaru.Add(m_bot_data);
        //             _context.SaveChangesAsync();
        //             transaction.Commit();

        //             // string result_success = "Berhasil";
        //             // string jsonInString_result_success = JsonConvert.SerializeObject(new{result_success});
        //             // JObject get_result_success = JObject.Parse(jsonInString_result_success);

        //             // return(result_success);
                    
        //         }
        //         catch (Exception ex)
        //         {
        //             // string status_fail = ex.Message;
        //             transaction.Rollback();

        //             // return(status_fail);
        //             throw;
        //         }
        //     }
        // }

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
