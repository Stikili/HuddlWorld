using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Huddl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Huddl.Pages.Beverage
{
    public class EditModel : PageModel
    {
   
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Beverages Beverages { get; set; }

        public async Task OnGet(int id)
        {
            Beverages = await _db.Beverages.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BeveragesFromDb = await _db.Beverages.FindAsync(Beverages.Id);
                BeveragesFromDb.Beverage = Beverages.Beverage;


                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }

}
