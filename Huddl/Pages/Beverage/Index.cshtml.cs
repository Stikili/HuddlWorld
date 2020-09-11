using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Huddl.Pages.Beverage;
using Huddl.Models;
using Microsoft.EntityFrameworkCore;

namespace Huddl.Pages.Beverage
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Beverages> Beverages { get; set; }

        public async Task OnGet()
        {
            Beverages = await _db.Beverages.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Beverages = await _db.Beverages.FindAsync(id);
            if (Beverages == null)
            {
                return NotFound();
            }
            _db.Beverages.Remove(Beverages);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}